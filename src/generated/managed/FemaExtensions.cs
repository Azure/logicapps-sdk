//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fema
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FemaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1DeclarationDenialsResponse, ApiConnectionActionConfiguration> GetV1DeclarationDenials(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1DeclarationDenialsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1DeclarationDenialsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1DeclarationDenialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/DeclarationDenials";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1DeclarationDenialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2DisasterDeclarationsSummariesResponse, ApiConnectionActionConfiguration> GetV2DisasterDeclarationsSummaries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2DisasterDeclarationsSummariesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2DisasterDeclarationsSummariesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2DisasterDeclarationsSummariesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/DisasterDeclarationsSummaries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2DisasterDeclarationsSummariesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1FemaWebDeclarationAreasResponse, ApiConnectionActionConfiguration> GetV1FemaWebDeclarationAreas(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1FemaWebDeclarationAreasOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1FemaWebDeclarationAreasSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1FemaWebDeclarationAreasResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/FemaWebDeclarationAreas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1FemaWebDeclarationAreasResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1FemaWebDisasterDeclarationsResponse, ApiConnectionActionConfiguration> GetV1FemaWebDisasterDeclarations(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1FemaWebDisasterDeclarationsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1FemaWebDisasterDeclarationsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1FemaWebDisasterDeclarationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/FemaWebDisasterDeclarations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1FemaWebDisasterDeclarationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1FemaWebDisasterSummariesResponse, ApiConnectionActionConfiguration> GetV1FemaWebDisasterSummaries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1FemaWebDisasterSummariesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1FemaWebDisasterSummariesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1FemaWebDisasterSummariesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/FemaWebDisasterSummaries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1FemaWebDisasterSummariesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2MissionAssignmentsResponse, ApiConnectionActionConfiguration> GetV2MissionAssignments(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2MissionAssignmentsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2MissionAssignmentsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2MissionAssignmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/MissionAssignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2MissionAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2EmergencyManagementPerformanceGrantsResponse, ApiConnectionActionConfiguration> GetV2EmergencyManagementPerformanceGrants(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2EmergencyManagementPerformanceGrantsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2EmergencyManagementPerformanceGrantsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2EmergencyManagementPerformanceGrantsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/EmergencyManagementPerformanceGrants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2EmergencyManagementPerformanceGrantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1IpawsArchivedAlertsResponse, ApiConnectionActionConfiguration> GetV1IpawsArchivedAlerts(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1IpawsArchivedAlertsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1IpawsArchivedAlertsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1IpawsArchivedAlertsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/IpawsArchivedAlerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1IpawsArchivedAlertsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NonDisasterAssistanceFirefighterGrantsResponse, ApiConnectionActionConfiguration> GetV1NonDisasterAssistanceFirefighterGrants(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1NonDisasterAssistanceFirefighterGrantsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1NonDisasterAssistanceFirefighterGrantsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1NonDisasterAssistanceFirefighterGrantsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/NonDisasterAssistanceFirefighterGrants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1NonDisasterAssistanceFirefighterGrantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V4HazardMitigationAssistanceMitigatedPropertiesResponse, ApiConnectionActionConfiguration> GetV4HazardMitigationAssistanceMitigatedProperties(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV4HazardMitigationAssistanceMitigatedPropertiesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV4HazardMitigationAssistanceMitigatedPropertiesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V4HazardMitigationAssistanceMitigatedPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/HazardMitigationAssistanceMitigatedProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V4HazardMitigationAssistanceMitigatedPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V4HazardMitigationAssistanceProjectsResponse, ApiConnectionActionConfiguration> GetV4HazardMitigationAssistanceProjects(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV4HazardMitigationAssistanceProjectsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV4HazardMitigationAssistanceProjectsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V4HazardMitigationAssistanceProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/HazardMitigationAssistanceProjects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V4HazardMitigationAssistanceProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesResponse, ApiConnectionActionConfiguration> GetV2HazardMitigationAssistanceProjectsByNfipCrsCommunities(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/HazardMitigationAssistanceProjectsByNfipCrsCommunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HazardMitigationAssistanceProjectsFinancialTransactionsResponse, ApiConnectionActionConfiguration> GetV1HazardMitigationAssistanceProjectsFinancialTransactions(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1HazardMitigationAssistanceProjectsFinancialTransactionsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1HazardMitigationAssistanceProjectsFinancialTransactionsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1HazardMitigationAssistanceProjectsFinancialTransactionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/HazardMitigationAssistanceProjectsFinancialTransactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1HazardMitigationAssistanceProjectsFinancialTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HazardMitigationGrantProgramDisasterSummariesResponse, ApiConnectionActionConfiguration> GetV2HazardMitigationGrantProgramDisasterSummaries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2HazardMitigationGrantProgramDisasterSummariesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2HazardMitigationGrantProgramDisasterSummariesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2HazardMitigationGrantProgramDisasterSummariesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/HazardMitigationGrantProgramDisasterSummaries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2HazardMitigationGrantProgramDisasterSummariesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HazardMitigationPlanStatusesResponse, ApiConnectionActionConfiguration> GetV1HazardMitigationPlanStatuses(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1HazardMitigationPlanStatusesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1HazardMitigationPlanStatusesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1HazardMitigationPlanStatusesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/HazardMitigationPlanStatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1HazardMitigationPlanStatusesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HmaSubapplicationsResponse, ApiConnectionActionConfiguration> GetV2HmaSubapplications(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2HmaSubapplicationsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2HmaSubapplicationsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2HmaSubapplicationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/HmaSubapplications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2HmaSubapplicationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HmaSubapplicationsByNfipCrsCommunitiesResponse, ApiConnectionActionConfiguration> GetV1HmaSubapplicationsByNfipCrsCommunities(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1HmaSubapplicationsByNfipCrsCommunitiesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1HmaSubapplicationsByNfipCrsCommunitiesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1HmaSubapplicationsByNfipCrsCommunitiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/HmaSubapplicationsByNfipCrsCommunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1HmaSubapplicationsByNfipCrsCommunitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HmaSubapplicationsFinancialTransactionsResponse, ApiConnectionActionConfiguration> GetV1HmaSubapplicationsFinancialTransactions(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1HmaSubapplicationsFinancialTransactionsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1HmaSubapplicationsFinancialTransactionsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1HmaSubapplicationsFinancialTransactionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/HmaSubapplicationsFinancialTransactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1HmaSubapplicationsFinancialTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HmaSubapplicationsProjectSiteInventoriesResponse, ApiConnectionActionConfiguration> GetV1HmaSubapplicationsProjectSiteInventories(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1HmaSubapplicationsProjectSiteInventoriesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1HmaSubapplicationsProjectSiteInventoriesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1HmaSubapplicationsProjectSiteInventoriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/HmaSubapplicationsProjectSiteInventories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1HmaSubapplicationsProjectSiteInventoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HousingAssistanceOwnersResponse, ApiConnectionActionConfiguration> GetV2HousingAssistanceOwners(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2HousingAssistanceOwnersOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2HousingAssistanceOwnersSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2HousingAssistanceOwnersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/HousingAssistanceOwners";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2HousingAssistanceOwnersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HousingAssistanceRentersResponse, ApiConnectionActionConfiguration> GetV2HousingAssistanceRenters(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2HousingAssistanceRentersOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2HousingAssistanceRentersSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2HousingAssistanceRentersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/HousingAssistanceRenters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2HousingAssistanceRentersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1IndividualAssistanceHousingRegistrantsLargeDisastersResponse, ApiConnectionActionConfiguration> GetV1IndividualAssistanceHousingRegistrantsLargeDisasters(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1IndividualAssistanceHousingRegistrantsLargeDisastersOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1IndividualAssistanceHousingRegistrantsLargeDisastersSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1IndividualAssistanceHousingRegistrantsLargeDisastersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/IndividualAssistanceHousingRegistrantsLargeDisasters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1IndividualAssistanceHousingRegistrantsLargeDisastersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1IndividualsAndHouseholdsProgramValidRegistrationsResponse, ApiConnectionActionConfiguration> GetV1IndividualsAndHouseholdsProgramValidRegistrations(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1IndividualsAndHouseholdsProgramValidRegistrationsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1IndividualsAndHouseholdsProgramValidRegistrationsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1IndividualsAndHouseholdsProgramValidRegistrationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/IndividualsAndHouseholdsProgramValidRegistrations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1IndividualsAndHouseholdsProgramValidRegistrationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2RegistrationIntakeIndividualsHouseholdProgramsResponse, ApiConnectionActionConfiguration> GetV2RegistrationIntakeIndividualsHouseholdPrograms(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2RegistrationIntakeIndividualsHouseholdProgramsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2RegistrationIntakeIndividualsHouseholdProgramsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2RegistrationIntakeIndividualsHouseholdProgramsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/RegistrationIntakeIndividualsHouseholdPrograms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2RegistrationIntakeIndividualsHouseholdProgramsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1DataSetFieldsResponse, ApiConnectionActionConfiguration> GetV1DataSetFields(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1DataSetFieldsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1DataSetFieldsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1DataSetFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/DataSetFields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1DataSetFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1DataSetsResponse, ApiConnectionActionConfiguration> GetV1DataSets(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1DataSetsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1DataSetsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1DataSetsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/DataSets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1DataSetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2FemaRegionsResponse, ApiConnectionActionConfiguration> GetV2FemaRegions(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2FemaRegionsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2FemaRegionsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2FemaRegionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FemaRegions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2FemaRegionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2FimaNfipClaimsResponse, ApiConnectionActionConfiguration> GetV2FimaNfipClaims(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2FimaNfipClaimsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2FimaNfipClaimsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2FimaNfipClaimsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FimaNfipClaims";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2FimaNfipClaimsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2FimaNfipPoliciesResponse, ApiConnectionActionConfiguration> GetV2FimaNfipPolicies(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2FimaNfipPoliciesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2FimaNfipPoliciesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2FimaNfipPoliciesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FimaNfipPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2FimaNfipPoliciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipCommunityLayerComprehensiveResponse, ApiConnectionActionConfiguration> GetV1NfipCommunityLayerComprehensive(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1NfipCommunityLayerComprehensiveOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1NfipCommunityLayerComprehensiveSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1NfipCommunityLayerComprehensiveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/NfipCommunityLayerComprehensive";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1NfipCommunityLayerComprehensiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipCommunityLayerNoOverlapsSplitResponse, ApiConnectionActionConfiguration> GetV1NfipCommunityLayerNoOverlapsSplit(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1NfipCommunityLayerNoOverlapsSplitOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1NfipCommunityLayerNoOverlapsSplitSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1NfipCommunityLayerNoOverlapsSplitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/NfipCommunityLayerNoOverlapsSplit";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1NfipCommunityLayerNoOverlapsSplitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipCommunityLayerNoOverlapsWholeResponse, ApiConnectionActionConfiguration> GetV1NfipCommunityLayerNoOverlapsWhole(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1NfipCommunityLayerNoOverlapsWholeOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1NfipCommunityLayerNoOverlapsWholeSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1NfipCommunityLayerNoOverlapsWholeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/NfipCommunityLayerNoOverlapsWhole";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1NfipCommunityLayerNoOverlapsWholeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipCommunityStatusBookResponse, ApiConnectionActionConfiguration> GetV1NfipCommunityStatusBook(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1NfipCommunityStatusBookOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1NfipCommunityStatusBookSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1NfipCommunityStatusBookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/NfipCommunityStatusBook";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1NfipCommunityStatusBookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipMultipleLossPropertiesResponse, ApiConnectionActionConfiguration> GetV1NfipMultipleLossProperties(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1NfipMultipleLossPropertiesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1NfipMultipleLossPropertiesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1NfipMultipleLossPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/NfipMultipleLossProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1NfipMultipleLossPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipResidentialPenetrationRatesResponse, ApiConnectionActionConfiguration> GetV1NfipResidentialPenetrationRates(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1NfipResidentialPenetrationRatesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1NfipResidentialPenetrationRatesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1NfipResidentialPenetrationRatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/NfipResidentialPenetrationRates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1NfipResidentialPenetrationRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1PublicAssistanceApplicantsResponse, ApiConnectionActionConfiguration> GetV1PublicAssistanceApplicants(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1PublicAssistanceApplicantsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1PublicAssistanceApplicantsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1PublicAssistanceApplicantsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/PublicAssistanceApplicants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1PublicAssistanceApplicantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1PublicAssistanceApplicantsProgramDeliveriesResponse, ApiConnectionActionConfiguration> GetV1PublicAssistanceApplicantsProgramDeliveries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1PublicAssistanceApplicantsProgramDeliveriesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1PublicAssistanceApplicantsProgramDeliveriesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1PublicAssistanceApplicantsProgramDeliveriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/PublicAssistanceApplicantsProgramDeliveries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1PublicAssistanceApplicantsProgramDeliveriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1PublicAssistanceFundedProjectsDetailsResponse, ApiConnectionActionConfiguration> GetV1PublicAssistanceFundedProjectsDetails(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1PublicAssistanceFundedProjectsDetailsOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1PublicAssistanceFundedProjectsDetailsSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1PublicAssistanceFundedProjectsDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/PublicAssistanceFundedProjectsDetails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1PublicAssistanceFundedProjectsDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1PublicAssistanceFundedProjectsSummariesResponse, ApiConnectionActionConfiguration> GetV1PublicAssistanceFundedProjectsSummaries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV1PublicAssistanceFundedProjectsSummariesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV1PublicAssistanceFundedProjectsSummariesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V1PublicAssistanceFundedProjectsSummariesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/PublicAssistanceFundedProjectsSummaries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V1PublicAssistanceFundedProjectsSummariesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2PublicAssistanceGrantAwardActivitiesResponse, ApiConnectionActionConfiguration> GetV2PublicAssistanceGrantAwardActivities(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> fileName = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<GetV2PublicAssistanceGrantAwardActivitiesOrderbyInputItem[]>> orderby = null, Expression<Func<GetV2PublicAssistanceGrantAwardActivitiesSelectInputItem[]>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_gzip = WorkflowExpression.Compile(gzip, nameof(gzip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<V2PublicAssistanceGrantAwardActivitiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/PublicAssistanceGrantAwardActivities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$top"] = Convert.ToString(1000);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$count"] = Convert.ToString(false);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_fileName != null)
                    callPayload.Queries["$filename"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["$metadata"] = Convert.ToString(true);
                if (__workflow_metadata != null)
                    callPayload.Queries["$metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_gzip != null)
                    callPayload.Queries["$gzip"] = ExpressionConverter.Convert(__workflow_gzip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$format"] = Convert.ToString("json");
                return new ApiConnectionAction<V2PublicAssistanceGrantAwardActivitiesResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1DeclarationDenialsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "declarationRequestNumber")]
        DeclarationRequestNumber,
        [EnumMember(Value = "declarationRequestNumber desc")]
        DeclarationRequestNumberDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "stateAbbreviation desc")]
        StateAbbreviationDesc,
        [EnumMember(Value = "tribalRequest")]
        TribalRequest,
        [EnumMember(Value = "tribalRequest desc")]
        TribalRequestDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "declarationRequestDate")]
        DeclarationRequestDate,
        [EnumMember(Value = "declarationRequestDate desc")]
        DeclarationRequestDateDesc,
        [EnumMember(Value = "declarationRequestType")]
        DeclarationRequestType,
        [EnumMember(Value = "declarationRequestType desc")]
        DeclarationRequestTypeDesc,
        [EnumMember(Value = "incidentName")]
        IncidentName,
        [EnumMember(Value = "incidentName desc")]
        IncidentNameDesc,
        [EnumMember(Value = "requestedIncidentTypes")]
        RequestedIncidentTypes,
        [EnumMember(Value = "requestedIncidentTypes desc")]
        RequestedIncidentTypesDesc,
        [EnumMember(Value = "currentRequestStatus")]
        CurrentRequestStatus,
        [EnumMember(Value = "currentRequestStatus desc")]
        CurrentRequestStatusDesc,
        [EnumMember(Value = "requestedIncidentBeginDate")]
        RequestedIncidentBeginDate,
        [EnumMember(Value = "requestedIncidentBeginDate desc")]
        RequestedIncidentBeginDateDesc,
        [EnumMember(Value = "requestedIncidentEndDate")]
        RequestedIncidentEndDate,
        [EnumMember(Value = "requestedIncidentEndDate desc")]
        RequestedIncidentEndDateDesc,
        [EnumMember(Value = "requestStatusDate")]
        RequestStatusDate,
        [EnumMember(Value = "requestStatusDate desc")]
        RequestStatusDateDesc,
        [EnumMember(Value = "ihProgramRequested")]
        IhProgramRequested,
        [EnumMember(Value = "ihProgramRequested desc")]
        IhProgramRequestedDesc,
        [EnumMember(Value = "iaProgramRequested")]
        IaProgramRequested,
        [EnumMember(Value = "iaProgramRequested desc")]
        IaProgramRequestedDesc,
        [EnumMember(Value = "paProgramRequested")]
        PaProgramRequested,
        [EnumMember(Value = "paProgramRequested desc")]
        PaProgramRequestedDesc,
        [EnumMember(Value = "hmProgramRequested")]
        HmProgramRequested,
        [EnumMember(Value = "hmProgramRequested desc")]
        HmProgramRequestedDesc,
        [EnumMember(Value = "incidentId")]
        IncidentId,
        [EnumMember(Value = "incidentId desc")]
        IncidentIdDesc,
        [EnumMember(Value = "incidentBeginDate")]
        IncidentBeginDate,
        [EnumMember(Value = "incidentBeginDate desc")]
        IncidentBeginDateDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1DeclarationDenialsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "declarationRequestNumber")]
        DeclarationRequestNumber,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "tribalRequest")]
        TribalRequest,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "declarationRequestDate")]
        DeclarationRequestDate,
        [EnumMember(Value = "declarationRequestType")]
        DeclarationRequestType,
        [EnumMember(Value = "incidentName")]
        IncidentName,
        [EnumMember(Value = "requestedIncidentTypes")]
        RequestedIncidentTypes,
        [EnumMember(Value = "currentRequestStatus")]
        CurrentRequestStatus,
        [EnumMember(Value = "requestedIncidentBeginDate")]
        RequestedIncidentBeginDate,
        [EnumMember(Value = "requestedIncidentEndDate")]
        RequestedIncidentEndDate,
        [EnumMember(Value = "requestStatusDate")]
        RequestStatusDate,
        [EnumMember(Value = "ihProgramRequested")]
        IhProgramRequested,
        [EnumMember(Value = "iaProgramRequested")]
        IaProgramRequested,
        [EnumMember(Value = "paProgramRequested")]
        PaProgramRequested,
        [EnumMember(Value = "hmProgramRequested")]
        HmProgramRequested,
        [EnumMember(Value = "incidentId")]
        IncidentId,
        [EnumMember(Value = "incidentBeginDate")]
        IncidentBeginDate
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2DisasterDeclarationsSummariesOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "femaDeclarationString")]
        FemaDeclarationString,
        [EnumMember(Value = "femaDeclarationString desc")]
        FemaDeclarationStringDesc,
        [EnumMember(Value = "declarationType")]
        DeclarationType,
        [EnumMember(Value = "declarationType desc")]
        DeclarationTypeDesc,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "declarationDate desc")]
        DeclarationDateDesc,
        [EnumMember(Value = "fyDeclared")]
        FyDeclared,
        [EnumMember(Value = "fyDeclared desc")]
        FyDeclaredDesc,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "incidentType desc")]
        IncidentTypeDesc,
        [EnumMember(Value = "declarationTitle")]
        DeclarationTitle,
        [EnumMember(Value = "declarationTitle desc")]
        DeclarationTitleDesc,
        [EnumMember(Value = "ihProgramDeclared")]
        IhProgramDeclared,
        [EnumMember(Value = "ihProgramDeclared desc")]
        IhProgramDeclaredDesc,
        [EnumMember(Value = "iaProgramDeclared")]
        IaProgramDeclared,
        [EnumMember(Value = "iaProgramDeclared desc")]
        IaProgramDeclaredDesc,
        [EnumMember(Value = "paProgramDeclared")]
        PaProgramDeclared,
        [EnumMember(Value = "paProgramDeclared desc")]
        PaProgramDeclaredDesc,
        [EnumMember(Value = "hmProgramDeclared")]
        HmProgramDeclared,
        [EnumMember(Value = "hmProgramDeclared desc")]
        HmProgramDeclaredDesc,
        [EnumMember(Value = "incidentBeginDate")]
        IncidentBeginDate,
        [EnumMember(Value = "incidentBeginDate desc")]
        IncidentBeginDateDesc,
        [EnumMember(Value = "incidentEndDate")]
        IncidentEndDate,
        [EnumMember(Value = "incidentEndDate desc")]
        IncidentEndDateDesc,
        [EnumMember(Value = "disasterCloseoutDate")]
        DisasterCloseoutDate,
        [EnumMember(Value = "disasterCloseoutDate desc")]
        DisasterCloseoutDateDesc,
        [EnumMember(Value = "tribalRequest")]
        TribalRequest,
        [EnumMember(Value = "tribalRequest desc")]
        TribalRequestDesc,
        [EnumMember(Value = "fipsStateCode")]
        FipsStateCode,
        [EnumMember(Value = "fipsStateCode desc")]
        FipsStateCodeDesc,
        [EnumMember(Value = "fipsCountyCode")]
        FipsCountyCode,
        [EnumMember(Value = "fipsCountyCode desc")]
        FipsCountyCodeDesc,
        [EnumMember(Value = "placeCode")]
        PlaceCode,
        [EnumMember(Value = "placeCode desc")]
        PlaceCodeDesc,
        [EnumMember(Value = "designatedArea")]
        DesignatedArea,
        [EnumMember(Value = "designatedArea desc")]
        DesignatedAreaDesc,
        [EnumMember(Value = "declarationRequestNumber")]
        DeclarationRequestNumber,
        [EnumMember(Value = "declarationRequestNumber desc")]
        DeclarationRequestNumberDesc,
        [EnumMember(Value = "lastIAFilingDate")]
        LastIAFilingDate,
        [EnumMember(Value = "lastIAFilingDate desc")]
        LastIAFilingDateDesc,
        [EnumMember(Value = "incidentId")]
        IncidentId,
        [EnumMember(Value = "incidentId desc")]
        IncidentIdDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "designatedIncidentTypes")]
        DesignatedIncidentTypes,
        [EnumMember(Value = "designatedIncidentTypes desc")]
        DesignatedIncidentTypesDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2DisasterDeclarationsSummariesSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "femaDeclarationString")]
        FemaDeclarationString,
        [EnumMember(Value = "declarationType")]
        DeclarationType,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "fyDeclared")]
        FyDeclared,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "declarationTitle")]
        DeclarationTitle,
        [EnumMember(Value = "ihProgramDeclared")]
        IhProgramDeclared,
        [EnumMember(Value = "iaProgramDeclared")]
        IaProgramDeclared,
        [EnumMember(Value = "paProgramDeclared")]
        PaProgramDeclared,
        [EnumMember(Value = "hmProgramDeclared")]
        HmProgramDeclared,
        [EnumMember(Value = "incidentBeginDate")]
        IncidentBeginDate,
        [EnumMember(Value = "incidentEndDate")]
        IncidentEndDate,
        [EnumMember(Value = "disasterCloseoutDate")]
        DisasterCloseoutDate,
        [EnumMember(Value = "tribalRequest")]
        TribalRequest,
        [EnumMember(Value = "fipsStateCode")]
        FipsStateCode,
        [EnumMember(Value = "fipsCountyCode")]
        FipsCountyCode,
        [EnumMember(Value = "placeCode")]
        PlaceCode,
        [EnumMember(Value = "designatedArea")]
        DesignatedArea,
        [EnumMember(Value = "declarationRequestNumber")]
        DeclarationRequestNumber,
        [EnumMember(Value = "lastIAFilingDate")]
        LastIAFilingDate,
        [EnumMember(Value = "incidentId")]
        IncidentId,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "designatedIncidentTypes")]
        DesignatedIncidentTypes,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1FemaWebDeclarationAreasOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "programTypeCode")]
        ProgramTypeCode,
        [EnumMember(Value = "programTypeCode desc")]
        ProgramTypeCodeDesc,
        [EnumMember(Value = "programTypeDescription")]
        ProgramTypeDescription,
        [EnumMember(Value = "programTypeDescription desc")]
        ProgramTypeDescriptionDesc,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateCode desc")]
        StateCodeDesc,
        [EnumMember(Value = "stateName")]
        StateName,
        [EnumMember(Value = "stateName desc")]
        StateNameDesc,
        [EnumMember(Value = "placeCode")]
        PlaceCode,
        [EnumMember(Value = "placeCode desc")]
        PlaceCodeDesc,
        [EnumMember(Value = "placeName")]
        PlaceName,
        [EnumMember(Value = "placeName desc")]
        PlaceNameDesc,
        [EnumMember(Value = "designatedDate")]
        DesignatedDate,
        [EnumMember(Value = "designatedDate desc")]
        DesignatedDateDesc,
        [EnumMember(Value = "entryDate")]
        EntryDate,
        [EnumMember(Value = "entryDate desc")]
        EntryDateDesc,
        [EnumMember(Value = "updateDate")]
        UpdateDate,
        [EnumMember(Value = "updateDate desc")]
        UpdateDateDesc,
        [EnumMember(Value = "closeoutDate")]
        CloseoutDate,
        [EnumMember(Value = "closeoutDate desc")]
        CloseoutDateDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1FemaWebDeclarationAreasSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "programTypeCode")]
        ProgramTypeCode,
        [EnumMember(Value = "programTypeDescription")]
        ProgramTypeDescription,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateName")]
        StateName,
        [EnumMember(Value = "placeCode")]
        PlaceCode,
        [EnumMember(Value = "placeName")]
        PlaceName,
        [EnumMember(Value = "designatedDate")]
        DesignatedDate,
        [EnumMember(Value = "entryDate")]
        EntryDate,
        [EnumMember(Value = "updateDate")]
        UpdateDate,
        [EnumMember(Value = "closeoutDate")]
        CloseoutDate,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1FemaWebDisasterDeclarationsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "declarationDate desc")]
        DeclarationDateDesc,
        [EnumMember(Value = "disasterName")]
        DisasterName,
        [EnumMember(Value = "disasterName desc")]
        DisasterNameDesc,
        [EnumMember(Value = "incidentBeginDate")]
        IncidentBeginDate,
        [EnumMember(Value = "incidentBeginDate desc")]
        IncidentBeginDateDesc,
        [EnumMember(Value = "incidentEndDate")]
        IncidentEndDate,
        [EnumMember(Value = "incidentEndDate desc")]
        IncidentEndDateDesc,
        [EnumMember(Value = "declarationType")]
        DeclarationType,
        [EnumMember(Value = "declarationType desc")]
        DeclarationTypeDesc,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateCode desc")]
        StateCodeDesc,
        [EnumMember(Value = "stateName")]
        StateName,
        [EnumMember(Value = "stateName desc")]
        StateNameDesc,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "incidentType desc")]
        IncidentTypeDesc,
        [EnumMember(Value = "entryDate")]
        EntryDate,
        [EnumMember(Value = "entryDate desc")]
        EntryDateDesc,
        [EnumMember(Value = "updateDate")]
        UpdateDate,
        [EnumMember(Value = "updateDate desc")]
        UpdateDateDesc,
        [EnumMember(Value = "closeoutDate")]
        CloseoutDate,
        [EnumMember(Value = "closeoutDate desc")]
        CloseoutDateDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "ihProgramDeclared")]
        IhProgramDeclared,
        [EnumMember(Value = "ihProgramDeclared desc")]
        IhProgramDeclaredDesc,
        [EnumMember(Value = "iaProgramDeclared")]
        IaProgramDeclared,
        [EnumMember(Value = "iaProgramDeclared desc")]
        IaProgramDeclaredDesc,
        [EnumMember(Value = "paProgramDeclared")]
        PaProgramDeclared,
        [EnumMember(Value = "paProgramDeclared desc")]
        PaProgramDeclaredDesc,
        [EnumMember(Value = "hmProgramDeclared")]
        HmProgramDeclared,
        [EnumMember(Value = "hmProgramDeclared desc")]
        HmProgramDeclaredDesc,
        [EnumMember(Value = "designatedIncidentTypes")]
        DesignatedIncidentTypes,
        [EnumMember(Value = "designatedIncidentTypes desc")]
        DesignatedIncidentTypesDesc,
        [EnumMember(Value = "declarationRequestDate")]
        DeclarationRequestDate,
        [EnumMember(Value = "declarationRequestDate desc")]
        DeclarationRequestDateDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1FemaWebDisasterDeclarationsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "disasterName")]
        DisasterName,
        [EnumMember(Value = "incidentBeginDate")]
        IncidentBeginDate,
        [EnumMember(Value = "incidentEndDate")]
        IncidentEndDate,
        [EnumMember(Value = "declarationType")]
        DeclarationType,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateName")]
        StateName,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "entryDate")]
        EntryDate,
        [EnumMember(Value = "updateDate")]
        UpdateDate,
        [EnumMember(Value = "closeoutDate")]
        CloseoutDate,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "ihProgramDeclared")]
        IhProgramDeclared,
        [EnumMember(Value = "iaProgramDeclared")]
        IaProgramDeclared,
        [EnumMember(Value = "paProgramDeclared")]
        PaProgramDeclared,
        [EnumMember(Value = "hmProgramDeclared")]
        HmProgramDeclared,
        [EnumMember(Value = "designatedIncidentTypes")]
        DesignatedIncidentTypes,
        [EnumMember(Value = "declarationRequestDate")]
        DeclarationRequestDate,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1FemaWebDisasterSummariesOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "totalNumberIaApproved")]
        TotalNumberIaApproved,
        [EnumMember(Value = "totalNumberIaApproved desc")]
        TotalNumberIaApprovedDesc,
        [EnumMember(Value = "totalAmountIhpApproved")]
        TotalAmountIhpApproved,
        [EnumMember(Value = "totalAmountIhpApproved desc")]
        TotalAmountIhpApprovedDesc,
        [EnumMember(Value = "totalAmountHaApproved")]
        TotalAmountHaApproved,
        [EnumMember(Value = "totalAmountHaApproved desc")]
        TotalAmountHaApprovedDesc,
        [EnumMember(Value = "totalAmountOnaApproved")]
        TotalAmountOnaApproved,
        [EnumMember(Value = "totalAmountOnaApproved desc")]
        TotalAmountOnaApprovedDesc,
        [EnumMember(Value = "totalObligatedAmountPa")]
        TotalObligatedAmountPa,
        [EnumMember(Value = "totalObligatedAmountPa desc")]
        TotalObligatedAmountPaDesc,
        [EnumMember(Value = "totalObligatedAmountCatAb")]
        TotalObligatedAmountCatAb,
        [EnumMember(Value = "totalObligatedAmountCatAb desc")]
        TotalObligatedAmountCatAbDesc,
        [EnumMember(Value = "totalObligatedAmountCatC2g")]
        TotalObligatedAmountCatC2g,
        [EnumMember(Value = "totalObligatedAmountCatC2g desc")]
        TotalObligatedAmountCatC2gDesc,
        [EnumMember(Value = "paLoadDate")]
        PaLoadDate,
        [EnumMember(Value = "paLoadDate desc")]
        PaLoadDateDesc,
        [EnumMember(Value = "iaLoadDate")]
        IaLoadDate,
        [EnumMember(Value = "iaLoadDate desc")]
        IaLoadDateDesc,
        [EnumMember(Value = "totalObligatedAmountHmgp")]
        TotalObligatedAmountHmgp,
        [EnumMember(Value = "totalObligatedAmountHmgp desc")]
        TotalObligatedAmountHmgpDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1FemaWebDisasterSummariesSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "totalNumberIaApproved")]
        TotalNumberIaApproved,
        [EnumMember(Value = "totalAmountIhpApproved")]
        TotalAmountIhpApproved,
        [EnumMember(Value = "totalAmountHaApproved")]
        TotalAmountHaApproved,
        [EnumMember(Value = "totalAmountOnaApproved")]
        TotalAmountOnaApproved,
        [EnumMember(Value = "totalObligatedAmountPa")]
        TotalObligatedAmountPa,
        [EnumMember(Value = "totalObligatedAmountCatAb")]
        TotalObligatedAmountCatAb,
        [EnumMember(Value = "totalObligatedAmountCatC2g")]
        TotalObligatedAmountCatC2g,
        [EnumMember(Value = "paLoadDate")]
        PaLoadDate,
        [EnumMember(Value = "iaLoadDate")]
        IaLoadDate,
        [EnumMember(Value = "totalObligatedAmountHmgp")]
        TotalObligatedAmountHmgp,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2MissionAssignmentsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "incidentId")]
        IncidentId,
        [EnumMember(Value = "incidentId desc")]
        IncidentIdDesc,
        [EnumMember(Value = "incidentName")]
        IncidentName,
        [EnumMember(Value = "incidentName desc")]
        IncidentNameDesc,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "incidentType desc")]
        IncidentTypeDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "declarationType")]
        DeclarationType,
        [EnumMember(Value = "declarationType desc")]
        DeclarationTypeDesc,
        [EnumMember(Value = "declarationTitle")]
        DeclarationTitle,
        [EnumMember(Value = "declarationTitle desc")]
        DeclarationTitleDesc,
        [EnumMember(Value = "maId")]
        MaId,
        [EnumMember(Value = "maId desc")]
        MaIdDesc,
        [EnumMember(Value = "maAmendNumber")]
        MaAmendNumber,
        [EnumMember(Value = "maAmendNumber desc")]
        MaAmendNumberDesc,
        [EnumMember(Value = "actionId")]
        ActionId,
        [EnumMember(Value = "actionId desc")]
        ActionIdDesc,
        [EnumMember(Value = "maType")]
        MaType,
        [EnumMember(Value = "maType desc")]
        MaTypeDesc,
        [EnumMember(Value = "supportFunction")]
        SupportFunction,
        [EnumMember(Value = "supportFunction desc")]
        SupportFunctionDesc,
        [EnumMember(Value = "priority")]
        Priority,
        [EnumMember(Value = "priority desc")]
        PriorityDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "stt")]
        Stt,
        [EnumMember(Value = "stt desc")]
        SttDesc,
        [EnumMember(Value = "agencyId")]
        AgencyId,
        [EnumMember(Value = "agencyId desc")]
        AgencyIdDesc,
        [EnumMember(Value = "agency")]
        Agency,
        [EnumMember(Value = "agency desc")]
        AgencyDesc,
        [EnumMember(Value = "authority")]
        Authority,
        [EnumMember(Value = "authority desc")]
        AuthorityDesc,
        [EnumMember(Value = "dateReceived")]
        DateReceived,
        [EnumMember(Value = "dateReceived desc")]
        DateReceivedDesc,
        [EnumMember(Value = "dateRequired")]
        DateRequired,
        [EnumMember(Value = "dateRequired desc")]
        DateRequiredDesc,
        [EnumMember(Value = "popStartDate")]
        PopStartDate,
        [EnumMember(Value = "popStartDate desc")]
        PopStartDateDesc,
        [EnumMember(Value = "popEndDate")]
        PopEndDate,
        [EnumMember(Value = "popEndDate desc")]
        PopEndDateDesc,
        [EnumMember(Value = "dateObligated")]
        DateObligated,
        [EnumMember(Value = "dateObligated desc")]
        DateObligatedDesc,
        [EnumMember(Value = "obligationAmount")]
        ObligationAmount,
        [EnumMember(Value = "obligationAmount desc")]
        ObligationAmountDesc,
        [EnumMember(Value = "sttCostSharePct")]
        SttCostSharePct,
        [EnumMember(Value = "sttCostSharePct desc")]
        SttCostSharePctDesc,
        [EnumMember(Value = "fedCostSharePct")]
        FedCostSharePct,
        [EnumMember(Value = "fedCostSharePct desc")]
        FedCostSharePctDesc,
        [EnumMember(Value = "sttCostShareAmt")]
        SttCostShareAmt,
        [EnumMember(Value = "sttCostShareAmt desc")]
        SttCostShareAmtDesc,
        [EnumMember(Value = "fedCostShareAmt")]
        FedCostShareAmt,
        [EnumMember(Value = "fedCostShareAmt desc")]
        FedCostShareAmtDesc,
        [EnumMember(Value = "maPopStartDate")]
        MaPopStartDate,
        [EnumMember(Value = "maPopStartDate desc")]
        MaPopStartDateDesc,
        [EnumMember(Value = "maPopEndDate")]
        MaPopEndDate,
        [EnumMember(Value = "maPopEndDate desc")]
        MaPopEndDateDesc,
        [EnumMember(Value = "maSttCostSharePct")]
        MaSttCostSharePct,
        [EnumMember(Value = "maSttCostSharePct desc")]
        MaSttCostSharePctDesc,
        [EnumMember(Value = "maFedCostSharePct")]
        MaFedCostSharePct,
        [EnumMember(Value = "maFedCostSharePct desc")]
        MaFedCostSharePctDesc,
        [EnumMember(Value = "maSttCostShareAmount")]
        MaSttCostShareAmount,
        [EnumMember(Value = "maSttCostShareAmount desc")]
        MaSttCostShareAmountDesc,
        [EnumMember(Value = "maFedCostShareAmount")]
        MaFedCostShareAmount,
        [EnumMember(Value = "maFedCostShareAmount desc")]
        MaFedCostShareAmountDesc,
        [EnumMember(Value = "maPriority")]
        MaPriority,
        [EnumMember(Value = "maPriority desc")]
        MaPriorityDesc,
        [EnumMember(Value = "assistanceRequested")]
        AssistanceRequested,
        [EnumMember(Value = "assistanceRequested desc")]
        AssistanceRequestedDesc,
        [EnumMember(Value = "statementOfWork")]
        StatementOfWork,
        [EnumMember(Value = "statementOfWork desc")]
        StatementOfWorkDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2MissionAssignmentsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "incidentId")]
        IncidentId,
        [EnumMember(Value = "incidentName")]
        IncidentName,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "declarationType")]
        DeclarationType,
        [EnumMember(Value = "declarationTitle")]
        DeclarationTitle,
        [EnumMember(Value = "maId")]
        MaId,
        [EnumMember(Value = "maAmendNumber")]
        MaAmendNumber,
        [EnumMember(Value = "actionId")]
        ActionId,
        [EnumMember(Value = "maType")]
        MaType,
        [EnumMember(Value = "supportFunction")]
        SupportFunction,
        [EnumMember(Value = "priority")]
        Priority,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "stt")]
        Stt,
        [EnumMember(Value = "agencyId")]
        AgencyId,
        [EnumMember(Value = "agency")]
        Agency,
        [EnumMember(Value = "authority")]
        Authority,
        [EnumMember(Value = "dateReceived")]
        DateReceived,
        [EnumMember(Value = "dateRequired")]
        DateRequired,
        [EnumMember(Value = "popStartDate")]
        PopStartDate,
        [EnumMember(Value = "popEndDate")]
        PopEndDate,
        [EnumMember(Value = "dateObligated")]
        DateObligated,
        [EnumMember(Value = "obligationAmount")]
        ObligationAmount,
        [EnumMember(Value = "sttCostSharePct")]
        SttCostSharePct,
        [EnumMember(Value = "fedCostSharePct")]
        FedCostSharePct,
        [EnumMember(Value = "sttCostShareAmt")]
        SttCostShareAmt,
        [EnumMember(Value = "fedCostShareAmt")]
        FedCostShareAmt,
        [EnumMember(Value = "maPopStartDate")]
        MaPopStartDate,
        [EnumMember(Value = "maPopEndDate")]
        MaPopEndDate,
        [EnumMember(Value = "maSttCostSharePct")]
        MaSttCostSharePct,
        [EnumMember(Value = "maFedCostSharePct")]
        MaFedCostSharePct,
        [EnumMember(Value = "maSttCostShareAmount")]
        MaSttCostShareAmount,
        [EnumMember(Value = "maFedCostShareAmount")]
        MaFedCostShareAmount,
        [EnumMember(Value = "maPriority")]
        MaPriority,
        [EnumMember(Value = "assistanceRequested")]
        AssistanceRequested,
        [EnumMember(Value = "statementOfWork")]
        StatementOfWork,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2EmergencyManagementPerformanceGrantsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "reportingPeriod")]
        ReportingPeriod,
        [EnumMember(Value = "reportingPeriod desc")]
        ReportingPeriodDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "legalAgencyName")]
        LegalAgencyName,
        [EnumMember(Value = "legalAgencyName desc")]
        LegalAgencyNameDesc,
        [EnumMember(Value = "projectType")]
        ProjectType,
        [EnumMember(Value = "projectType desc")]
        ProjectTypeDesc,
        [EnumMember(Value = "projectStartDate")]
        ProjectStartDate,
        [EnumMember(Value = "projectStartDate desc")]
        ProjectStartDateDesc,
        [EnumMember(Value = "projectEndDate")]
        ProjectEndDate,
        [EnumMember(Value = "projectEndDate desc")]
        ProjectEndDateDesc,
        [EnumMember(Value = "nameOfProgram")]
        NameOfProgram,
        [EnumMember(Value = "nameOfProgram desc")]
        NameOfProgramDesc,
        [EnumMember(Value = "fundingAmount")]
        FundingAmount,
        [EnumMember(Value = "fundingAmount desc")]
        FundingAmountDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2EmergencyManagementPerformanceGrantsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "reportingPeriod")]
        ReportingPeriod,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "legalAgencyName")]
        LegalAgencyName,
        [EnumMember(Value = "projectType")]
        ProjectType,
        [EnumMember(Value = "projectStartDate")]
        ProjectStartDate,
        [EnumMember(Value = "projectEndDate")]
        ProjectEndDate,
        [EnumMember(Value = "nameOfProgram")]
        NameOfProgram,
        [EnumMember(Value = "fundingAmount")]
        FundingAmount
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1IpawsArchivedAlertsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "identifier")]
        Identifier,
        [EnumMember(Value = "identifier desc")]
        IdentifierDesc,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "sent desc")]
        SentDesc,
        [EnumMember(Value = "sender")]
        Sender,
        [EnumMember(Value = "sender desc")]
        SenderDesc,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "status desc")]
        StatusDesc,
        [EnumMember(Value = "msgType")]
        MsgType,
        [EnumMember(Value = "msgType desc")]
        MsgTypeDesc,
        [EnumMember(Value = "source")]
        Source,
        [EnumMember(Value = "source desc")]
        SourceDesc,
        [EnumMember(Value = "scope")]
        Scope,
        [EnumMember(Value = "scope desc")]
        ScopeDesc,
        [EnumMember(Value = "restriction")]
        Restriction,
        [EnumMember(Value = "restriction desc")]
        RestrictionDesc,
        [EnumMember(Value = "addresses")]
        Addresses,
        [EnumMember(Value = "addresses desc")]
        AddressesDesc,
        [EnumMember(Value = "code")]
        Code,
        [EnumMember(Value = "code desc")]
        CodeDesc,
        [EnumMember(Value = "note")]
        Note,
        [EnumMember(Value = "note desc")]
        NoteDesc,
        [EnumMember(Value = "incidents")]
        Incidents,
        [EnumMember(Value = "incidents desc")]
        IncidentsDesc,
        [EnumMember(Value = "searchGeometry")]
        SearchGeometry,
        [EnumMember(Value = "searchGeometry desc")]
        SearchGeometryDesc,
        [EnumMember(Value = "infos")]
        Infos,
        [EnumMember(Value = "infos desc")]
        InfosDesc,
        [EnumMember(Value = "cogId")]
        CogId,
        [EnumMember(Value = "cogId desc")]
        CogIdDesc,
        [EnumMember(Value = "xmlns")]
        Xmlns,
        [EnumMember(Value = "xmlns desc")]
        XmlnsDesc,
        [EnumMember(Value = "originalMessage")]
        OriginalMessage,
        [EnumMember(Value = "originalMessage desc")]
        OriginalMessageDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1IpawsArchivedAlertsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "identifier")]
        Identifier,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "sender")]
        Sender,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "msgType")]
        MsgType,
        [EnumMember(Value = "source")]
        Source,
        [EnumMember(Value = "scope")]
        Scope,
        [EnumMember(Value = "restriction")]
        Restriction,
        [EnumMember(Value = "addresses")]
        Addresses,
        [EnumMember(Value = "code")]
        Code,
        [EnumMember(Value = "note")]
        Note,
        [EnumMember(Value = "incidents")]
        Incidents,
        [EnumMember(Value = "searchGeometry")]
        SearchGeometry,
        [EnumMember(Value = "infos")]
        Infos,
        [EnumMember(Value = "cogId")]
        CogId,
        [EnumMember(Value = "xmlns")]
        Xmlns,
        [EnumMember(Value = "originalMessage")]
        OriginalMessage
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NonDisasterAssistanceFirefighterGrantsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "awardNumber")]
        AwardNumber,
        [EnumMember(Value = "awardNumber desc")]
        AwardNumberDesc,
        [EnumMember(Value = "fiscalYear")]
        FiscalYear,
        [EnumMember(Value = "fiscalYear desc")]
        FiscalYearDesc,
        [EnumMember(Value = "programName")]
        ProgramName,
        [EnumMember(Value = "programName desc")]
        ProgramNameDesc,
        [EnumMember(Value = "programAbbreviation")]
        ProgramAbbreviation,
        [EnumMember(Value = "programAbbreviation desc")]
        ProgramAbbreviationDesc,
        [EnumMember(Value = "vendorState")]
        VendorState,
        [EnumMember(Value = "vendorState desc")]
        VendorStateDesc,
        [EnumMember(Value = "awardAmount")]
        AwardAmount,
        [EnumMember(Value = "awardAmount desc")]
        AwardAmountDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "vendorName")]
        VendorName,
        [EnumMember(Value = "vendorName desc")]
        VendorNameDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NonDisasterAssistanceFirefighterGrantsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "awardNumber")]
        AwardNumber,
        [EnumMember(Value = "fiscalYear")]
        FiscalYear,
        [EnumMember(Value = "programName")]
        ProgramName,
        [EnumMember(Value = "programAbbreviation")]
        ProgramAbbreviation,
        [EnumMember(Value = "vendorState")]
        VendorState,
        [EnumMember(Value = "awardAmount")]
        AwardAmount,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "vendorName")]
        VendorName
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV4HazardMitigationAssistanceMitigatedPropertiesOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "propertyPartOfProject")]
        PropertyPartOfProject,
        [EnumMember(Value = "propertyPartOfProject desc")]
        PropertyPartOfProjectDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "stateNumberCode")]
        StateNumberCode,
        [EnumMember(Value = "stateNumberCode desc")]
        StateNumberCodeDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "foundationType")]
        FoundationType,
        [EnumMember(Value = "foundationType desc")]
        FoundationTypeDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "city desc")]
        CityDesc,
        [EnumMember(Value = "zip")]
        Zip,
        [EnumMember(Value = "zip desc")]
        ZipDesc,
        [EnumMember(Value = "projectIdentifier")]
        ProjectIdentifier,
        [EnumMember(Value = "projectIdentifier desc")]
        ProjectIdentifierDesc,
        [EnumMember(Value = "propertyAction")]
        PropertyAction,
        [EnumMember(Value = "propertyAction desc")]
        PropertyActionDesc,
        [EnumMember(Value = "structureType")]
        StructureType,
        [EnumMember(Value = "structureType desc")]
        StructureTypeDesc,
        [EnumMember(Value = "typeOfResidency")]
        TypeOfResidency,
        [EnumMember(Value = "typeOfResidency desc")]
        TypeOfResidencyDesc,
        [EnumMember(Value = "actualAmountPaid")]
        ActualAmountPaid,
        [EnumMember(Value = "actualAmountPaid desc")]
        ActualAmountPaidDesc,
        [EnumMember(Value = "programFy")]
        ProgramFy,
        [EnumMember(Value = "programFy desc")]
        ProgramFyDesc,
        [EnumMember(Value = "programArea")]
        ProgramArea,
        [EnumMember(Value = "programArea desc")]
        ProgramAreaDesc,
        [EnumMember(Value = "numberOfProperties")]
        NumberOfProperties,
        [EnumMember(Value = "numberOfProperties desc")]
        NumberOfPropertiesDesc,
        [EnumMember(Value = "damageCategory")]
        DamageCategory,
        [EnumMember(Value = "damageCategory desc")]
        DamageCategoryDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV4HazardMitigationAssistanceMitigatedPropertiesSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "propertyPartOfProject")]
        PropertyPartOfProject,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "stateNumberCode")]
        StateNumberCode,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "foundationType")]
        FoundationType,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "zip")]
        Zip,
        [EnumMember(Value = "projectIdentifier")]
        ProjectIdentifier,
        [EnumMember(Value = "propertyAction")]
        PropertyAction,
        [EnumMember(Value = "structureType")]
        StructureType,
        [EnumMember(Value = "typeOfResidency")]
        TypeOfResidency,
        [EnumMember(Value = "actualAmountPaid")]
        ActualAmountPaid,
        [EnumMember(Value = "programFy")]
        ProgramFy,
        [EnumMember(Value = "programArea")]
        ProgramArea,
        [EnumMember(Value = "numberOfProperties")]
        NumberOfProperties,
        [EnumMember(Value = "damageCategory")]
        DamageCategory
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV4HazardMitigationAssistanceProjectsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "stateNumberCode")]
        StateNumberCode,
        [EnumMember(Value = "stateNumberCode desc")]
        StateNumberCodeDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "countyCode desc")]
        CountyCodeDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "programArea")]
        ProgramArea,
        [EnumMember(Value = "programArea desc")]
        ProgramAreaDesc,
        [EnumMember(Value = "projectIdentifier")]
        ProjectIdentifier,
        [EnumMember(Value = "projectIdentifier desc")]
        ProjectIdentifierDesc,
        [EnumMember(Value = "projectType")]
        ProjectType,
        [EnumMember(Value = "projectType desc")]
        ProjectTypeDesc,
        [EnumMember(Value = "projectCounties")]
        ProjectCounties,
        [EnumMember(Value = "projectCounties desc")]
        ProjectCountiesDesc,
        [EnumMember(Value = "numberOfProperties")]
        NumberOfProperties,
        [EnumMember(Value = "numberOfProperties desc")]
        NumberOfPropertiesDesc,
        [EnumMember(Value = "numberOfFinalProperties")]
        NumberOfFinalProperties,
        [EnumMember(Value = "numberOfFinalProperties desc")]
        NumberOfFinalPropertiesDesc,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "status desc")]
        StatusDesc,
        [EnumMember(Value = "subrecipient")]
        Subrecipient,
        [EnumMember(Value = "subrecipient desc")]
        SubrecipientDesc,
        [EnumMember(Value = "projectAmount")]
        ProjectAmount,
        [EnumMember(Value = "projectAmount desc")]
        ProjectAmountDesc,
        [EnumMember(Value = "initialObligationDate")]
        InitialObligationDate,
        [EnumMember(Value = "initialObligationDate desc")]
        InitialObligationDateDesc,
        [EnumMember(Value = "initialObligationAmount")]
        InitialObligationAmount,
        [EnumMember(Value = "initialObligationAmount desc")]
        InitialObligationAmountDesc,
        [EnumMember(Value = "costSharePercentage")]
        CostSharePercentage,
        [EnumMember(Value = "costSharePercentage desc")]
        CostSharePercentageDesc,
        [EnumMember(Value = "federalShareObligated")]
        FederalShareObligated,
        [EnumMember(Value = "federalShareObligated desc")]
        FederalShareObligatedDesc,
        [EnumMember(Value = "programFy")]
        ProgramFy,
        [EnumMember(Value = "programFy desc")]
        ProgramFyDesc,
        [EnumMember(Value = "dateInitiallyApproved")]
        DateInitiallyApproved,
        [EnumMember(Value = "dateInitiallyApproved desc")]
        DateInitiallyApprovedDesc,
        [EnumMember(Value = "dateApproved")]
        DateApproved,
        [EnumMember(Value = "dateApproved desc")]
        DateApprovedDesc,
        [EnumMember(Value = "dateClosed")]
        DateClosed,
        [EnumMember(Value = "dateClosed desc")]
        DateClosedDesc,
        [EnumMember(Value = "recipientTribalIndicator")]
        RecipientTribalIndicator,
        [EnumMember(Value = "recipientTribalIndicator desc")]
        RecipientTribalIndicatorDesc,
        [EnumMember(Value = "recipient")]
        Recipient,
        [EnumMember(Value = "recipient desc")]
        RecipientDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "benefitCostRatio")]
        BenefitCostRatio,
        [EnumMember(Value = "benefitCostRatio desc")]
        BenefitCostRatioDesc,
        [EnumMember(Value = "netValueBenefits")]
        NetValueBenefits,
        [EnumMember(Value = "netValueBenefits desc")]
        NetValueBenefitsDesc,
        [EnumMember(Value = "subrecipientTribalIndicator")]
        SubrecipientTribalIndicator,
        [EnumMember(Value = "subrecipientTribalIndicator desc")]
        SubrecipientTribalIndicatorDesc,
        [EnumMember(Value = "dataSource")]
        DataSource,
        [EnumMember(Value = "dataSource desc")]
        DataSourceDesc,
        [EnumMember(Value = "subrecipientAdminCostAmt")]
        SubrecipientAdminCostAmt,
        [EnumMember(Value = "subrecipientAdminCostAmt desc")]
        SubrecipientAdminCostAmtDesc,
        [EnumMember(Value = "recipientAdminCostAmt")]
        RecipientAdminCostAmt,
        [EnumMember(Value = "recipientAdminCostAmt desc")]
        RecipientAdminCostAmtDesc,
        [EnumMember(Value = "srmcObligatedAmt")]
        SrmcObligatedAmt,
        [EnumMember(Value = "srmcObligatedAmt desc")]
        SrmcObligatedAmtDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV4HazardMitigationAssistanceProjectsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "stateNumberCode")]
        StateNumberCode,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "programArea")]
        ProgramArea,
        [EnumMember(Value = "projectIdentifier")]
        ProjectIdentifier,
        [EnumMember(Value = "projectType")]
        ProjectType,
        [EnumMember(Value = "projectCounties")]
        ProjectCounties,
        [EnumMember(Value = "numberOfProperties")]
        NumberOfProperties,
        [EnumMember(Value = "numberOfFinalProperties")]
        NumberOfFinalProperties,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "subrecipient")]
        Subrecipient,
        [EnumMember(Value = "projectAmount")]
        ProjectAmount,
        [EnumMember(Value = "initialObligationDate")]
        InitialObligationDate,
        [EnumMember(Value = "initialObligationAmount")]
        InitialObligationAmount,
        [EnumMember(Value = "costSharePercentage")]
        CostSharePercentage,
        [EnumMember(Value = "federalShareObligated")]
        FederalShareObligated,
        [EnumMember(Value = "programFy")]
        ProgramFy,
        [EnumMember(Value = "dateInitiallyApproved")]
        DateInitiallyApproved,
        [EnumMember(Value = "dateApproved")]
        DateApproved,
        [EnumMember(Value = "dateClosed")]
        DateClosed,
        [EnumMember(Value = "recipientTribalIndicator")]
        RecipientTribalIndicator,
        [EnumMember(Value = "recipient")]
        Recipient,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "benefitCostRatio")]
        BenefitCostRatio,
        [EnumMember(Value = "netValueBenefits")]
        NetValueBenefits,
        [EnumMember(Value = "subrecipientTribalIndicator")]
        SubrecipientTribalIndicator,
        [EnumMember(Value = "dataSource")]
        DataSource,
        [EnumMember(Value = "subrecipientAdminCostAmt")]
        SubrecipientAdminCostAmt,
        [EnumMember(Value = "recipientAdminCostAmt")]
        RecipientAdminCostAmt,
        [EnumMember(Value = "srmcObligatedAmt")]
        SrmcObligatedAmt
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "projectIdentifier")]
        ProjectIdentifier,
        [EnumMember(Value = "projectIdentifier desc")]
        ProjectIdentifierDesc,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityName desc")]
        CommunityNameDesc,
        [EnumMember(Value = "communityNumber")]
        CommunityNumber,
        [EnumMember(Value = "communityNumber desc")]
        CommunityNumberDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "projectIdentifier")]
        ProjectIdentifier,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityNumber")]
        CommunityNumber,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HazardMitigationAssistanceProjectsFinancialTransactionsOrderbyInputItem
    {
        [EnumMember(Value = "projectIdentifier")]
        ProjectIdentifier,
        [EnumMember(Value = "projectIdentifier desc")]
        ProjectIdentifierDesc,
        [EnumMember(Value = "transactionIdentifier")]
        TransactionIdentifier,
        [EnumMember(Value = "transactionIdentifier desc")]
        TransactionIdentifierDesc,
        [EnumMember(Value = "transactionDate")]
        TransactionDate,
        [EnumMember(Value = "transactionDate desc")]
        TransactionDateDesc,
        [EnumMember(Value = "commitmentIdentifier")]
        CommitmentIdentifier,
        [EnumMember(Value = "commitmentIdentifier desc")]
        CommitmentIdentifierDesc,
        [EnumMember(Value = "accsLine")]
        AccsLine,
        [EnumMember(Value = "accsLine desc")]
        AccsLineDesc,
        [EnumMember(Value = "fundCode")]
        FundCode,
        [EnumMember(Value = "fundCode desc")]
        FundCodeDesc,
        [EnumMember(Value = "federalShareProjectCostAmt")]
        FederalShareProjectCostAmt,
        [EnumMember(Value = "federalShareProjectCostAmt desc")]
        FederalShareProjectCostAmtDesc,
        [EnumMember(Value = "recipientAdminCostAmt")]
        RecipientAdminCostAmt,
        [EnumMember(Value = "recipientAdminCostAmt desc")]
        RecipientAdminCostAmtDesc,
        [EnumMember(Value = "subrecipientAdminCostAmt")]
        SubrecipientAdminCostAmt,
        [EnumMember(Value = "subrecipientAdminCostAmt desc")]
        SubrecipientAdminCostAmtDesc,
        [EnumMember(Value = "subrecipientMgmtCostAmt")]
        SubrecipientMgmtCostAmt,
        [EnumMember(Value = "subrecipientMgmtCostAmt desc")]
        SubrecipientMgmtCostAmtDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HazardMitigationAssistanceProjectsFinancialTransactionsSelectInputItem
    {
        [EnumMember(Value = "projectIdentifier")]
        ProjectIdentifier,
        [EnumMember(Value = "transactionIdentifier")]
        TransactionIdentifier,
        [EnumMember(Value = "transactionDate")]
        TransactionDate,
        [EnumMember(Value = "commitmentIdentifier")]
        CommitmentIdentifier,
        [EnumMember(Value = "accsLine")]
        AccsLine,
        [EnumMember(Value = "fundCode")]
        FundCode,
        [EnumMember(Value = "federalShareProjectCostAmt")]
        FederalShareProjectCostAmt,
        [EnumMember(Value = "recipientAdminCostAmt")]
        RecipientAdminCostAmt,
        [EnumMember(Value = "subrecipientAdminCostAmt")]
        SubrecipientAdminCostAmt,
        [EnumMember(Value = "subrecipientMgmtCostAmt")]
        SubrecipientMgmtCostAmt,
        [EnumMember(Value = "id")]
        Id
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HazardMitigationGrantProgramDisasterSummariesOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "declarationDate desc")]
        DeclarationDateDesc,
        [EnumMember(Value = "disasterType")]
        DisasterType,
        [EnumMember(Value = "disasterType desc")]
        DisasterTypeDesc,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "incidentType desc")]
        IncidentTypeDesc,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "title desc")]
        TitleDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "disasterCloseoutStatus")]
        DisasterCloseoutStatus,
        [EnumMember(Value = "disasterCloseoutStatus desc")]
        DisasterCloseoutStatusDesc,
        [EnumMember(Value = "hmgpCloseoutStatus")]
        HmgpCloseoutStatus,
        [EnumMember(Value = "hmgpCloseoutStatus desc")]
        HmgpCloseoutStatusDesc,
        [EnumMember(Value = "disasterCloseoutDate")]
        DisasterCloseoutDate,
        [EnumMember(Value = "disasterCloseoutDate desc")]
        DisasterCloseoutDateDesc,
        [EnumMember(Value = "hmgpReconciliationDate")]
        HmgpReconciliationDate,
        [EnumMember(Value = "hmgpReconciliationDate desc")]
        HmgpReconciliationDateDesc,
        [EnumMember(Value = "disasterDueDateForNewApps")]
        DisasterDueDateForNewApps,
        [EnumMember(Value = "disasterDueDateForNewApps desc")]
        DisasterDueDateForNewAppsDesc,
        [EnumMember(Value = "disasterPopEndDate")]
        DisasterPopEndDate,
        [EnumMember(Value = "disasterPopEndDate desc")]
        DisasterPopEndDateDesc,
        [EnumMember(Value = "hmgpPopEndDate")]
        HmgpPopEndDate,
        [EnumMember(Value = "hmgpPopEndDate desc")]
        HmgpPopEndDateDesc,
        [EnumMember(Value = "hmgpPopExtnDate")]
        HmgpPopExtnDate,
        [EnumMember(Value = "hmgpPopExtnDate desc")]
        HmgpPopExtnDateDesc,
        [EnumMember(Value = "hmgpPopExtnNum")]
        HmgpPopExtnNum,
        [EnumMember(Value = "hmgpPopExtnNum desc")]
        HmgpPopExtnNumDesc,
        [EnumMember(Value = "liqPeriodDate")]
        LiqPeriodDate,
        [EnumMember(Value = "liqPeriodDate desc")]
        LiqPeriodDateDesc,
        [EnumMember(Value = "liqPeriodMaxDate")]
        LiqPeriodMaxDate,
        [EnumMember(Value = "liqPeriodMaxDate desc")]
        LiqPeriodMaxDateDesc,
        [EnumMember(Value = "liqPeriodMaxPopNum")]
        LiqPeriodMaxPopNum,
        [EnumMember(Value = "liqPeriodMaxPopNum desc")]
        LiqPeriodMaxPopNumDesc,
        [EnumMember(Value = "liqPeriodMaxExtDate")]
        LiqPeriodMaxExtDate,
        [EnumMember(Value = "liqPeriodMaxExtDate desc")]
        LiqPeriodMaxExtDateDesc,
        [EnumMember(Value = "liqPeriodMaxExtNum")]
        LiqPeriodMaxExtNum,
        [EnumMember(Value = "liqPeriodMaxExtNum desc")]
        LiqPeriodMaxExtNumDesc,
        [EnumMember(Value = "mitigationDollarsAvailable")]
        MitigationDollarsAvailable,
        [EnumMember(Value = "mitigationDollarsAvailable desc")]
        MitigationDollarsAvailableDesc,
        [EnumMember(Value = "lockedInCeilingAmount")]
        LockedInCeilingAmount,
        [EnumMember(Value = "lockedInCeilingAmount desc")]
        LockedInCeilingAmountDesc,
        [EnumMember(Value = "obligatedTotalAmount")]
        ObligatedTotalAmount,
        [EnumMember(Value = "obligatedTotalAmount desc")]
        ObligatedTotalAmountDesc,
        [EnumMember(Value = "obligatedInitiativeAmount")]
        ObligatedInitiativeAmount,
        [EnumMember(Value = "obligatedInitiativeAmount desc")]
        ObligatedInitiativeAmountDesc,
        [EnumMember(Value = "obligatedPlanningAmount")]
        ObligatedPlanningAmount,
        [EnumMember(Value = "obligatedPlanningAmount desc")]
        ObligatedPlanningAmountDesc,
        [EnumMember(Value = "obligatedRegularAmount")]
        ObligatedRegularAmount,
        [EnumMember(Value = "obligatedRegularAmount desc")]
        ObligatedRegularAmountDesc,
        [EnumMember(Value = "obligatedRecipientMgmtAmt")]
        ObligatedRecipientMgmtAmt,
        [EnumMember(Value = "obligatedRecipientMgmtAmt desc")]
        ObligatedRecipientMgmtAmtDesc,
        [EnumMember(Value = "obligatedRecipientAdmin")]
        ObligatedRecipientAdmin,
        [EnumMember(Value = "obligatedRecipientAdmin desc")]
        ObligatedRecipientAdminDesc,
        [EnumMember(Value = "obligatedSubrecipientAdmin")]
        ObligatedSubrecipientAdmin,
        [EnumMember(Value = "obligatedSubrecipientAdmin desc")]
        ObligatedSubrecipientAdminDesc,
        [EnumMember(Value = "obligatedSubrecipMgmtAmt")]
        ObligatedSubrecipMgmtAmt,
        [EnumMember(Value = "obligatedSubrecipMgmtAmt desc")]
        ObligatedSubrecipMgmtAmtDesc,
        [EnumMember(Value = "pendingProjectsQuantity")]
        PendingProjectsQuantity,
        [EnumMember(Value = "pendingProjectsQuantity desc")]
        PendingProjectsQuantityDesc,
        [EnumMember(Value = "pendingFedShareProposedAmt")]
        PendingFedShareProposedAmt,
        [EnumMember(Value = "pendingFedShareProposedAmt desc")]
        PendingFedShareProposedAmtDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HazardMitigationGrantProgramDisasterSummariesSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "disasterType")]
        DisasterType,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "disasterCloseoutStatus")]
        DisasterCloseoutStatus,
        [EnumMember(Value = "hmgpCloseoutStatus")]
        HmgpCloseoutStatus,
        [EnumMember(Value = "disasterCloseoutDate")]
        DisasterCloseoutDate,
        [EnumMember(Value = "hmgpReconciliationDate")]
        HmgpReconciliationDate,
        [EnumMember(Value = "disasterDueDateForNewApps")]
        DisasterDueDateForNewApps,
        [EnumMember(Value = "disasterPopEndDate")]
        DisasterPopEndDate,
        [EnumMember(Value = "hmgpPopEndDate")]
        HmgpPopEndDate,
        [EnumMember(Value = "hmgpPopExtnDate")]
        HmgpPopExtnDate,
        [EnumMember(Value = "hmgpPopExtnNum")]
        HmgpPopExtnNum,
        [EnumMember(Value = "liqPeriodDate")]
        LiqPeriodDate,
        [EnumMember(Value = "liqPeriodMaxDate")]
        LiqPeriodMaxDate,
        [EnumMember(Value = "liqPeriodMaxPopNum")]
        LiqPeriodMaxPopNum,
        [EnumMember(Value = "liqPeriodMaxExtDate")]
        LiqPeriodMaxExtDate,
        [EnumMember(Value = "liqPeriodMaxExtNum")]
        LiqPeriodMaxExtNum,
        [EnumMember(Value = "mitigationDollarsAvailable")]
        MitigationDollarsAvailable,
        [EnumMember(Value = "lockedInCeilingAmount")]
        LockedInCeilingAmount,
        [EnumMember(Value = "obligatedTotalAmount")]
        ObligatedTotalAmount,
        [EnumMember(Value = "obligatedInitiativeAmount")]
        ObligatedInitiativeAmount,
        [EnumMember(Value = "obligatedPlanningAmount")]
        ObligatedPlanningAmount,
        [EnumMember(Value = "obligatedRegularAmount")]
        ObligatedRegularAmount,
        [EnumMember(Value = "obligatedRecipientMgmtAmt")]
        ObligatedRecipientMgmtAmt,
        [EnumMember(Value = "obligatedRecipientAdmin")]
        ObligatedRecipientAdmin,
        [EnumMember(Value = "obligatedSubrecipientAdmin")]
        ObligatedSubrecipientAdmin,
        [EnumMember(Value = "obligatedSubrecipMgmtAmt")]
        ObligatedSubrecipMgmtAmt,
        [EnumMember(Value = "pendingProjectsQuantity")]
        PendingProjectsQuantity,
        [EnumMember(Value = "pendingFedShareProposedAmt")]
        PendingFedShareProposedAmt,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HazardMitigationPlanStatusesOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "femaRegion")]
        FemaRegion,
        [EnumMember(Value = "femaRegion desc")]
        FemaRegionDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "stateAbbreviation desc")]
        StateAbbreviationDesc,
        [EnumMember(Value = "countyName")]
        CountyName,
        [EnumMember(Value = "countyName desc")]
        CountyNameDesc,
        [EnumMember(Value = "placeName")]
        PlaceName,
        [EnumMember(Value = "placeName desc")]
        PlaceNameDesc,
        [EnumMember(Value = "planType")]
        PlanType,
        [EnumMember(Value = "planType desc")]
        PlanTypeDesc,
        [EnumMember(Value = "planId")]
        PlanId,
        [EnumMember(Value = "planId desc")]
        PlanIdDesc,
        [EnumMember(Value = "planTitle")]
        PlanTitle,
        [EnumMember(Value = "planTitle desc")]
        PlanTitleDesc,
        [EnumMember(Value = "planStatus")]
        PlanStatus,
        [EnumMember(Value = "planStatus desc")]
        PlanStatusDesc,
        [EnumMember(Value = "apaDate")]
        ApaDate,
        [EnumMember(Value = "apaDate desc")]
        ApaDateDesc,
        [EnumMember(Value = "planApprovalDate")]
        PlanApprovalDate,
        [EnumMember(Value = "planApprovalDate desc")]
        PlanApprovalDateDesc,
        [EnumMember(Value = "planExpirationDate")]
        PlanExpirationDate,
        [EnumMember(Value = "planExpirationDate desc")]
        PlanExpirationDateDesc,
        [EnumMember(Value = "jurisdictionType")]
        JurisdictionType,
        [EnumMember(Value = "jurisdictionType desc")]
        JurisdictionTypeDesc,
        [EnumMember(Value = "jurisdictionStatus")]
        JurisdictionStatus,
        [EnumMember(Value = "jurisdictionStatus desc")]
        JurisdictionStatusDesc,
        [EnumMember(Value = "adoptionDate")]
        AdoptionDate,
        [EnumMember(Value = "adoptionDate desc")]
        AdoptionDateDesc,
        [EnumMember(Value = "jurisdictionApprovalDate")]
        JurisdictionApprovalDate,
        [EnumMember(Value = "jurisdictionApprovalDate desc")]
        JurisdictionApprovalDateDesc,
        [EnumMember(Value = "population")]
        Population,
        [EnumMember(Value = "population desc")]
        PopulationDesc,
        [EnumMember(Value = "mppGeoid")]
        MppGeoid,
        [EnumMember(Value = "mppGeoid desc")]
        MppGeoidDesc,
        [EnumMember(Value = "censusSource")]
        CensusSource,
        [EnumMember(Value = "censusSource desc")]
        CensusSourceDesc,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "communityIdNumber desc")]
        CommunityIdNumberDesc,
        [EnumMember(Value = "popCoverage")]
        PopCoverage,
        [EnumMember(Value = "popCoverage desc")]
        PopCoverageDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HazardMitigationPlanStatusesSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "femaRegion")]
        FemaRegion,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "countyName")]
        CountyName,
        [EnumMember(Value = "placeName")]
        PlaceName,
        [EnumMember(Value = "planType")]
        PlanType,
        [EnumMember(Value = "planId")]
        PlanId,
        [EnumMember(Value = "planTitle")]
        PlanTitle,
        [EnumMember(Value = "planStatus")]
        PlanStatus,
        [EnumMember(Value = "apaDate")]
        ApaDate,
        [EnumMember(Value = "planApprovalDate")]
        PlanApprovalDate,
        [EnumMember(Value = "planExpirationDate")]
        PlanExpirationDate,
        [EnumMember(Value = "jurisdictionType")]
        JurisdictionType,
        [EnumMember(Value = "jurisdictionStatus")]
        JurisdictionStatus,
        [EnumMember(Value = "adoptionDate")]
        AdoptionDate,
        [EnumMember(Value = "jurisdictionApprovalDate")]
        JurisdictionApprovalDate,
        [EnumMember(Value = "population")]
        Population,
        [EnumMember(Value = "mppGeoid")]
        MppGeoid,
        [EnumMember(Value = "censusSource")]
        CensusSource,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "popCoverage")]
        PopCoverage
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HmaSubapplicationsOrderbyInputItem
    {
        [EnumMember(Value = "subapplicationIdentifier")]
        SubapplicationIdentifier,
        [EnumMember(Value = "subapplicationIdentifier desc")]
        SubapplicationIdentifierDesc,
        [EnumMember(Value = "program")]
        Program,
        [EnumMember(Value = "program desc")]
        ProgramDesc,
        [EnumMember(Value = "fiscalYear")]
        FiscalYear,
        [EnumMember(Value = "fiscalYear desc")]
        FiscalYearDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "applicantUei")]
        ApplicantUei,
        [EnumMember(Value = "applicantUei desc")]
        ApplicantUeiDesc,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "applicantName desc")]
        ApplicantNameDesc,
        [EnumMember(Value = "subapplicantUei")]
        SubapplicantUei,
        [EnumMember(Value = "subapplicantUei desc")]
        SubapplicantUeiDesc,
        [EnumMember(Value = "subapplicantName")]
        SubapplicantName,
        [EnumMember(Value = "subapplicantName desc")]
        SubapplicantNameDesc,
        [EnumMember(Value = "subapplicantCity")]
        SubapplicantCity,
        [EnumMember(Value = "subapplicantCity desc")]
        SubapplicantCityDesc,
        [EnumMember(Value = "subapplicantState")]
        SubapplicantState,
        [EnumMember(Value = "subapplicantState desc")]
        SubapplicantStateDesc,
        [EnumMember(Value = "subapplicantStateAbbreviation")]
        SubapplicantStateAbbreviation,
        [EnumMember(Value = "subapplicantStateAbbreviation desc")]
        SubapplicantStateAbbreviationDesc,
        [EnumMember(Value = "subapplicantZipCode")]
        SubapplicantZipCode,
        [EnumMember(Value = "subapplicantZipCode desc")]
        SubapplicantZipCodeDesc,
        [EnumMember(Value = "subapplicantZip4")]
        SubapplicantZip4,
        [EnumMember(Value = "subapplicantZip4 desc")]
        SubapplicantZip4Desc,
        [EnumMember(Value = "subjectEO12372")]
        SubjectEO12372,
        [EnumMember(Value = "subjectEO12372 desc")]
        SubjectEO12372Desc,
        [EnumMember(Value = "eo12372ReviewDate")]
        Eo12372ReviewDate,
        [EnumMember(Value = "eo12372ReviewDate desc")]
        Eo12372ReviewDateDesc,
        [EnumMember(Value = "subapplicantFederalDebt")]
        SubapplicantFederalDebt,
        [EnumMember(Value = "subapplicantFederalDebt desc")]
        SubapplicantFederalDebtDesc,
        [EnumMember(Value = "dateInitiatedInSystem")]
        DateInitiatedInSystem,
        [EnumMember(Value = "dateInitiatedInSystem desc")]
        DateInitiatedInSystemDesc,
        [EnumMember(Value = "dateSubmittedToApplicant")]
        DateSubmittedToApplicant,
        [EnumMember(Value = "dateSubmittedToApplicant desc")]
        DateSubmittedToApplicantDesc,
        [EnumMember(Value = "dateSubmittedToFema")]
        DateSubmittedToFema,
        [EnumMember(Value = "dateSubmittedToFema desc")]
        DateSubmittedToFemaDesc,
        [EnumMember(Value = "subapplicationTitle")]
        SubapplicationTitle,
        [EnumMember(Value = "subapplicationTitle desc")]
        SubapplicationTitleDesc,
        [EnumMember(Value = "proposedProjectStartDate")]
        ProposedProjectStartDate,
        [EnumMember(Value = "proposedProjectStartDate desc")]
        ProposedProjectStartDateDesc,
        [EnumMember(Value = "proposedProjectEndDate")]
        ProposedProjectEndDate,
        [EnumMember(Value = "proposedProjectEndDate desc")]
        ProposedProjectEndDateDesc,
        [EnumMember(Value = "estimatedTotalDuration")]
        EstimatedTotalDuration,
        [EnumMember(Value = "estimatedTotalDuration desc")]
        EstimatedTotalDurationDesc,
        [EnumMember(Value = "fundingCategory")]
        FundingCategory,
        [EnumMember(Value = "fundingCategory desc")]
        FundingCategoryDesc,
        [EnumMember(Value = "subapplicantType")]
        SubapplicantType,
        [EnumMember(Value = "subapplicantType desc")]
        SubapplicantTypeDesc,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "status desc")]
        StatusDesc,
        [EnumMember(Value = "subapplicationType")]
        SubapplicationType,
        [EnumMember(Value = "subapplicationType desc")]
        SubapplicationTypeDesc,
        [EnumMember(Value = "benefitingCounties")]
        BenefitingCounties,
        [EnumMember(Value = "benefitingCounties desc")]
        BenefitingCountiesDesc,
        [EnumMember(Value = "primaryActivity")]
        PrimaryActivity,
        [EnumMember(Value = "primaryActivity desc")]
        PrimaryActivityDesc,
        [EnumMember(Value = "primarySubactivity")]
        PrimarySubactivity,
        [EnumMember(Value = "primarySubactivity desc")]
        PrimarySubactivityDesc,
        [EnumMember(Value = "secondaryActivity")]
        SecondaryActivity,
        [EnumMember(Value = "secondaryActivity desc")]
        SecondaryActivityDesc,
        [EnumMember(Value = "secondarySubactivity")]
        SecondarySubactivity,
        [EnumMember(Value = "secondarySubactivity desc")]
        SecondarySubactivityDesc,
        [EnumMember(Value = "tertiaryActivity")]
        TertiaryActivity,
        [EnumMember(Value = "tertiaryActivity desc")]
        TertiaryActivityDesc,
        [EnumMember(Value = "tertiarySubactivity")]
        TertiarySubactivity,
        [EnumMember(Value = "tertiarySubactivity desc")]
        TertiarySubactivityDesc,
        [EnumMember(Value = "primaryCommunityLifeline")]
        PrimaryCommunityLifeline,
        [EnumMember(Value = "primaryCommunityLifeline desc")]
        PrimaryCommunityLifelineDesc,
        [EnumMember(Value = "primaryCommunityLifelineComponent")]
        PrimaryCommunityLifelineComponent,
        [EnumMember(Value = "primaryCommunityLifelineComponent desc")]
        PrimaryCommunityLifelineComponentDesc,
        [EnumMember(Value = "secondaryCommunityLifeline")]
        SecondaryCommunityLifeline,
        [EnumMember(Value = "secondaryCommunityLifeline desc")]
        SecondaryCommunityLifelineDesc,
        [EnumMember(Value = "secondaryCommunityLifelineComponent")]
        SecondaryCommunityLifelineComponent,
        [EnumMember(Value = "secondaryCommunityLifelineComponent desc")]
        SecondaryCommunityLifelineComponentDesc,
        [EnumMember(Value = "tertiaryCommunityLifeline")]
        TertiaryCommunityLifeline,
        [EnumMember(Value = "tertiaryCommunityLifeline desc")]
        TertiaryCommunityLifelineDesc,
        [EnumMember(Value = "tertiaryCommunityLifelineComponent")]
        TertiaryCommunityLifelineComponent,
        [EnumMember(Value = "tertiaryCommunityLifelineComponent desc")]
        TertiaryCommunityLifelineComponentDesc,
        [EnumMember(Value = "primaryHazard")]
        PrimaryHazard,
        [EnumMember(Value = "primaryHazard desc")]
        PrimaryHazardDesc,
        [EnumMember(Value = "secondaryHazard")]
        SecondaryHazard,
        [EnumMember(Value = "secondaryHazard desc")]
        SecondaryHazardDesc,
        [EnumMember(Value = "tertiaryHazard")]
        TertiaryHazard,
        [EnumMember(Value = "tertiaryHazard desc")]
        TertiaryHazardDesc,
        [EnumMember(Value = "natureBasedSolution")]
        NatureBasedSolution,
        [EnumMember(Value = "natureBasedSolution desc")]
        NatureBasedSolutionDesc,
        [EnumMember(Value = "smallImpoverished")]
        SmallImpoverished,
        [EnumMember(Value = "smallImpoverished desc")]
        SmallImpoverishedDesc,
        [EnumMember(Value = "populationAffected")]
        PopulationAffected,
        [EnumMember(Value = "populationAffected desc")]
        PopulationAffectedDesc,
        [EnumMember(Value = "phasedProject")]
        PhasedProject,
        [EnumMember(Value = "phasedProject desc")]
        PhasedProjectDesc,
        [EnumMember(Value = "construction")]
        Construction,
        [EnumMember(Value = "construction desc")]
        ConstructionDesc,
        [EnumMember(Value = "priorSubapplication")]
        PriorSubapplication,
        [EnumMember(Value = "priorSubapplication desc")]
        PriorSubapplicationDesc,
        [EnumMember(Value = "communityRatingSystem")]
        CommunityRatingSystem,
        [EnumMember(Value = "communityRatingSystem desc")]
        CommunityRatingSystemDesc,
        [EnumMember(Value = "crsRating")]
        CrsRating,
        [EnumMember(Value = "crsRating desc")]
        CrsRatingDesc,
        [EnumMember(Value = "cooperatingTechnicalPartner")]
        CooperatingTechnicalPartner,
        [EnumMember(Value = "cooperatingTechnicalPartner desc")]
        CooperatingTechnicalPartnerDesc,
        [EnumMember(Value = "adoptedIcc")]
        AdoptedIcc,
        [EnumMember(Value = "adoptedIcc desc")]
        AdoptedIccDesc,
        [EnumMember(Value = "yearBuildingCode")]
        YearBuildingCode,
        [EnumMember(Value = "yearBuildingCode desc")]
        YearBuildingCodeDesc,
        [EnumMember(Value = "buildingCodesOnBcegs")]
        BuildingCodesOnBcegs,
        [EnumMember(Value = "buildingCodesOnBcegs desc")]
        BuildingCodesOnBcegsDesc,
        [EnumMember(Value = "bcegsRating")]
        BcegsRating,
        [EnumMember(Value = "bcegsRating desc")]
        BcegsRatingDesc,
        [EnumMember(Value = "mitigationPlanCovered")]
        MitigationPlanCovered,
        [EnumMember(Value = "mitigationPlanCovered desc")]
        MitigationPlanCoveredDesc,
        [EnumMember(Value = "mitigationPlanType")]
        MitigationPlanType,
        [EnumMember(Value = "mitigationPlanType desc")]
        MitigationPlanTypeDesc,
        [EnumMember(Value = "mitigationPlanSubtype")]
        MitigationPlanSubtype,
        [EnumMember(Value = "mitigationPlanSubtype desc")]
        MitigationPlanSubtypeDesc,
        [EnumMember(Value = "dateMitigationPlanApproved")]
        DateMitigationPlanApproved,
        [EnumMember(Value = "dateMitigationPlanApproved desc")]
        DateMitigationPlanApprovedDesc,
        [EnumMember(Value = "costEffectivenessMethod")]
        CostEffectivenessMethod,
        [EnumMember(Value = "costEffectivenessMethod desc")]
        CostEffectivenessMethodDesc,
        [EnumMember(Value = "preCalculatedBenefit")]
        PreCalculatedBenefit,
        [EnumMember(Value = "preCalculatedBenefit desc")]
        PreCalculatedBenefitDesc,
        [EnumMember(Value = "environmentalBenefit")]
        EnvironmentalBenefit,
        [EnumMember(Value = "environmentalBenefit desc")]
        EnvironmentalBenefitDesc,
        [EnumMember(Value = "seaLevelRise")]
        SeaLevelRise,
        [EnumMember(Value = "seaLevelRise desc")]
        SeaLevelRiseDesc,
        [EnumMember(Value = "socialBenefit")]
        SocialBenefit,
        [EnumMember(Value = "socialBenefit desc")]
        SocialBenefitDesc,
        [EnumMember(Value = "mitigatingProjectSiteInventory")]
        MitigatingProjectSiteInventory,
        [EnumMember(Value = "mitigatingProjectSiteInventory desc")]
        MitigatingProjectSiteInventoryDesc,
        [EnumMember(Value = "projectSiteInventoryLocationKnown")]
        ProjectSiteInventoryLocationKnown,
        [EnumMember(Value = "projectSiteInventoryLocationKnown desc")]
        ProjectSiteInventoryLocationKnownDesc,
        [EnumMember(Value = "numberBuildingLocations")]
        NumberBuildingLocations,
        [EnumMember(Value = "numberBuildingLocations desc")]
        NumberBuildingLocationsDesc,
        [EnumMember(Value = "numberInfrastructureLocations")]
        NumberInfrastructureLocations,
        [EnumMember(Value = "numberInfrastructureLocations desc")]
        NumberInfrastructureLocationsDesc,
        [EnumMember(Value = "numberVacantLandLocations")]
        NumberVacantLandLocations,
        [EnumMember(Value = "numberVacantLandLocations desc")]
        NumberVacantLandLocationsDesc,
        [EnumMember(Value = "federalShareAmount")]
        FederalShareAmount,
        [EnumMember(Value = "federalShareAmount desc")]
        FederalShareAmountDesc,
        [EnumMember(Value = "nonFederalShareAmount")]
        NonFederalShareAmount,
        [EnumMember(Value = "nonFederalShareAmount desc")]
        NonFederalShareAmountDesc,
        [EnumMember(Value = "mgmtFederalShareAmount")]
        MgmtFederalShareAmount,
        [EnumMember(Value = "mgmtFederalShareAmount desc")]
        MgmtFederalShareAmountDesc,
        [EnumMember(Value = "mgmtNonFederalShareAmount")]
        MgmtNonFederalShareAmount,
        [EnumMember(Value = "mgmtNonFederalShareAmount desc")]
        MgmtNonFederalShareAmountDesc,
        [EnumMember(Value = "totalSubapplicationAmount")]
        TotalSubapplicationAmount,
        [EnumMember(Value = "totalSubapplicationAmount desc")]
        TotalSubapplicationAmountDesc,
        [EnumMember(Value = "totalObligatedAmount")]
        TotalObligatedAmount,
        [EnumMember(Value = "totalObligatedAmount desc")]
        TotalObligatedAmountDesc,
        [EnumMember(Value = "totalPaymentAmount")]
        TotalPaymentAmount,
        [EnumMember(Value = "totalPaymentAmount desc")]
        TotalPaymentAmountDesc,
        [EnumMember(Value = "federalSharePercentage")]
        FederalSharePercentage,
        [EnumMember(Value = "federalSharePercentage desc")]
        FederalSharePercentageDesc,
        [EnumMember(Value = "nonFederalSharePercentage")]
        NonFederalSharePercentage,
        [EnumMember(Value = "nonFederalSharePercentage desc")]
        NonFederalSharePercentageDesc,
        [EnumMember(Value = "benefitCostRatio")]
        BenefitCostRatio,
        [EnumMember(Value = "benefitCostRatio desc")]
        BenefitCostRatioDesc,
        [EnumMember(Value = "bcaTotalBenefits")]
        BcaTotalBenefits,
        [EnumMember(Value = "bcaTotalBenefits desc")]
        BcaTotalBenefitsDesc,
        [EnumMember(Value = "bcaTotalCosts")]
        BcaTotalCosts,
        [EnumMember(Value = "bcaTotalCosts desc")]
        BcaTotalCostsDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "selectionStatus")]
        SelectionStatus,
        [EnumMember(Value = "selectionStatus desc")]
        SelectionStatusDesc,
        [EnumMember(Value = "selectionFundingCategory")]
        SelectionFundingCategory,
        [EnumMember(Value = "selectionFundingCategory desc")]
        SelectionFundingCategoryDesc,
        [EnumMember(Value = "selectionProgramActivity")]
        SelectionProgramActivity,
        [EnumMember(Value = "selectionProgramActivity desc")]
        SelectionProgramActivityDesc,
        [EnumMember(Value = "selectionFederalShareAmount")]
        SelectionFederalShareAmount,
        [EnumMember(Value = "selectionFederalShareAmount desc")]
        SelectionFederalShareAmountDesc,
        [EnumMember(Value = "selectionFundCode")]
        SelectionFundCode,
        [EnumMember(Value = "selectionFundCode desc")]
        SelectionFundCodeDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HmaSubapplicationsSelectInputItem
    {
        [EnumMember(Value = "subapplicationIdentifier")]
        SubapplicationIdentifier,
        [EnumMember(Value = "program")]
        Program,
        [EnumMember(Value = "fiscalYear")]
        FiscalYear,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "applicantUei")]
        ApplicantUei,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "subapplicantUei")]
        SubapplicantUei,
        [EnumMember(Value = "subapplicantName")]
        SubapplicantName,
        [EnumMember(Value = "subapplicantCity")]
        SubapplicantCity,
        [EnumMember(Value = "subapplicantState")]
        SubapplicantState,
        [EnumMember(Value = "subapplicantStateAbbreviation")]
        SubapplicantStateAbbreviation,
        [EnumMember(Value = "subapplicantZipCode")]
        SubapplicantZipCode,
        [EnumMember(Value = "subapplicantZip4")]
        SubapplicantZip4,
        [EnumMember(Value = "subjectEO12372")]
        SubjectEO12372,
        [EnumMember(Value = "eo12372ReviewDate")]
        Eo12372ReviewDate,
        [EnumMember(Value = "subapplicantFederalDebt")]
        SubapplicantFederalDebt,
        [EnumMember(Value = "dateInitiatedInSystem")]
        DateInitiatedInSystem,
        [EnumMember(Value = "dateSubmittedToApplicant")]
        DateSubmittedToApplicant,
        [EnumMember(Value = "dateSubmittedToFema")]
        DateSubmittedToFema,
        [EnumMember(Value = "subapplicationTitle")]
        SubapplicationTitle,
        [EnumMember(Value = "proposedProjectStartDate")]
        ProposedProjectStartDate,
        [EnumMember(Value = "proposedProjectEndDate")]
        ProposedProjectEndDate,
        [EnumMember(Value = "estimatedTotalDuration")]
        EstimatedTotalDuration,
        [EnumMember(Value = "fundingCategory")]
        FundingCategory,
        [EnumMember(Value = "subapplicantType")]
        SubapplicantType,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "subapplicationType")]
        SubapplicationType,
        [EnumMember(Value = "benefitingCounties")]
        BenefitingCounties,
        [EnumMember(Value = "primaryActivity")]
        PrimaryActivity,
        [EnumMember(Value = "primarySubactivity")]
        PrimarySubactivity,
        [EnumMember(Value = "secondaryActivity")]
        SecondaryActivity,
        [EnumMember(Value = "secondarySubactivity")]
        SecondarySubactivity,
        [EnumMember(Value = "tertiaryActivity")]
        TertiaryActivity,
        [EnumMember(Value = "tertiarySubactivity")]
        TertiarySubactivity,
        [EnumMember(Value = "primaryCommunityLifeline")]
        PrimaryCommunityLifeline,
        [EnumMember(Value = "primaryCommunityLifelineComponent")]
        PrimaryCommunityLifelineComponent,
        [EnumMember(Value = "secondaryCommunityLifeline")]
        SecondaryCommunityLifeline,
        [EnumMember(Value = "secondaryCommunityLifelineComponent")]
        SecondaryCommunityLifelineComponent,
        [EnumMember(Value = "tertiaryCommunityLifeline")]
        TertiaryCommunityLifeline,
        [EnumMember(Value = "tertiaryCommunityLifelineComponent")]
        TertiaryCommunityLifelineComponent,
        [EnumMember(Value = "primaryHazard")]
        PrimaryHazard,
        [EnumMember(Value = "secondaryHazard")]
        SecondaryHazard,
        [EnumMember(Value = "tertiaryHazard")]
        TertiaryHazard,
        [EnumMember(Value = "natureBasedSolution")]
        NatureBasedSolution,
        [EnumMember(Value = "smallImpoverished")]
        SmallImpoverished,
        [EnumMember(Value = "populationAffected")]
        PopulationAffected,
        [EnumMember(Value = "phasedProject")]
        PhasedProject,
        [EnumMember(Value = "construction")]
        Construction,
        [EnumMember(Value = "priorSubapplication")]
        PriorSubapplication,
        [EnumMember(Value = "communityRatingSystem")]
        CommunityRatingSystem,
        [EnumMember(Value = "crsRating")]
        CrsRating,
        [EnumMember(Value = "cooperatingTechnicalPartner")]
        CooperatingTechnicalPartner,
        [EnumMember(Value = "adoptedIcc")]
        AdoptedIcc,
        [EnumMember(Value = "yearBuildingCode")]
        YearBuildingCode,
        [EnumMember(Value = "buildingCodesOnBcegs")]
        BuildingCodesOnBcegs,
        [EnumMember(Value = "bcegsRating")]
        BcegsRating,
        [EnumMember(Value = "mitigationPlanCovered")]
        MitigationPlanCovered,
        [EnumMember(Value = "mitigationPlanType")]
        MitigationPlanType,
        [EnumMember(Value = "mitigationPlanSubtype")]
        MitigationPlanSubtype,
        [EnumMember(Value = "dateMitigationPlanApproved")]
        DateMitigationPlanApproved,
        [EnumMember(Value = "costEffectivenessMethod")]
        CostEffectivenessMethod,
        [EnumMember(Value = "preCalculatedBenefit")]
        PreCalculatedBenefit,
        [EnumMember(Value = "environmentalBenefit")]
        EnvironmentalBenefit,
        [EnumMember(Value = "seaLevelRise")]
        SeaLevelRise,
        [EnumMember(Value = "socialBenefit")]
        SocialBenefit,
        [EnumMember(Value = "mitigatingProjectSiteInventory")]
        MitigatingProjectSiteInventory,
        [EnumMember(Value = "projectSiteInventoryLocationKnown")]
        ProjectSiteInventoryLocationKnown,
        [EnumMember(Value = "numberBuildingLocations")]
        NumberBuildingLocations,
        [EnumMember(Value = "numberInfrastructureLocations")]
        NumberInfrastructureLocations,
        [EnumMember(Value = "numberVacantLandLocations")]
        NumberVacantLandLocations,
        [EnumMember(Value = "federalShareAmount")]
        FederalShareAmount,
        [EnumMember(Value = "nonFederalShareAmount")]
        NonFederalShareAmount,
        [EnumMember(Value = "mgmtFederalShareAmount")]
        MgmtFederalShareAmount,
        [EnumMember(Value = "mgmtNonFederalShareAmount")]
        MgmtNonFederalShareAmount,
        [EnumMember(Value = "totalSubapplicationAmount")]
        TotalSubapplicationAmount,
        [EnumMember(Value = "totalObligatedAmount")]
        TotalObligatedAmount,
        [EnumMember(Value = "totalPaymentAmount")]
        TotalPaymentAmount,
        [EnumMember(Value = "federalSharePercentage")]
        FederalSharePercentage,
        [EnumMember(Value = "nonFederalSharePercentage")]
        NonFederalSharePercentage,
        [EnumMember(Value = "benefitCostRatio")]
        BenefitCostRatio,
        [EnumMember(Value = "bcaTotalBenefits")]
        BcaTotalBenefits,
        [EnumMember(Value = "bcaTotalCosts")]
        BcaTotalCosts,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "selectionStatus")]
        SelectionStatus,
        [EnumMember(Value = "selectionFundingCategory")]
        SelectionFundingCategory,
        [EnumMember(Value = "selectionProgramActivity")]
        SelectionProgramActivity,
        [EnumMember(Value = "selectionFederalShareAmount")]
        SelectionFederalShareAmount,
        [EnumMember(Value = "selectionFundCode")]
        SelectionFundCode,
        [EnumMember(Value = "id")]
        Id
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HmaSubapplicationsByNfipCrsCommunitiesOrderbyInputItem
    {
        [EnumMember(Value = "subapplicationIdentifier")]
        SubapplicationIdentifier,
        [EnumMember(Value = "subapplicationIdentifier desc")]
        SubapplicationIdentifierDesc,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityName desc")]
        CommunityNameDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "stateAbbreviation desc")]
        StateAbbreviationDesc,
        [EnumMember(Value = "communityNumber")]
        CommunityNumber,
        [EnumMember(Value = "communityNumber desc")]
        CommunityNumberDesc,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "countyCode desc")]
        CountyCodeDesc,
        [EnumMember(Value = "stateNumberCode")]
        StateNumberCode,
        [EnumMember(Value = "stateNumberCode desc")]
        StateNumberCodeDesc,
        [EnumMember(Value = "isCrsCommunity")]
        IsCrsCommunity,
        [EnumMember(Value = "isCrsCommunity desc")]
        IsCrsCommunityDesc,
        [EnumMember(Value = "crsRating")]
        CrsRating,
        [EnumMember(Value = "crsRating desc")]
        CrsRatingDesc,
        [EnumMember(Value = "congressionalDistrict")]
        CongressionalDistrict,
        [EnumMember(Value = "congressionalDistrict desc")]
        CongressionalDistrictDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HmaSubapplicationsByNfipCrsCommunitiesSelectInputItem
    {
        [EnumMember(Value = "subapplicationIdentifier")]
        SubapplicationIdentifier,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "communityNumber")]
        CommunityNumber,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "stateNumberCode")]
        StateNumberCode,
        [EnumMember(Value = "isCrsCommunity")]
        IsCrsCommunity,
        [EnumMember(Value = "crsRating")]
        CrsRating,
        [EnumMember(Value = "congressionalDistrict")]
        CongressionalDistrict,
        [EnumMember(Value = "id")]
        Id
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HmaSubapplicationsFinancialTransactionsOrderbyInputItem
    {
        [EnumMember(Value = "subapplicationIdentifier")]
        SubapplicationIdentifier,
        [EnumMember(Value = "subapplicationIdentifier desc")]
        SubapplicationIdentifierDesc,
        [EnumMember(Value = "transactionType")]
        TransactionType,
        [EnumMember(Value = "transactionType desc")]
        TransactionTypeDesc,
        [EnumMember(Value = "transactionDate")]
        TransactionDate,
        [EnumMember(Value = "transactionDate desc")]
        TransactionDateDesc,
        [EnumMember(Value = "commitmentIdentifier")]
        CommitmentIdentifier,
        [EnumMember(Value = "commitmentIdentifier desc")]
        CommitmentIdentifierDesc,
        [EnumMember(Value = "paymentNumber")]
        PaymentNumber,
        [EnumMember(Value = "paymentNumber desc")]
        PaymentNumberDesc,
        [EnumMember(Value = "accsLine")]
        AccsLine,
        [EnumMember(Value = "accsLine desc")]
        AccsLineDesc,
        [EnumMember(Value = "fundCode")]
        FundCode,
        [EnumMember(Value = "fundCode desc")]
        FundCodeDesc,
        [EnumMember(Value = "amount")]
        Amount,
        [EnumMember(Value = "amount desc")]
        AmountDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HmaSubapplicationsFinancialTransactionsSelectInputItem
    {
        [EnumMember(Value = "subapplicationIdentifier")]
        SubapplicationIdentifier,
        [EnumMember(Value = "transactionType")]
        TransactionType,
        [EnumMember(Value = "transactionDate")]
        TransactionDate,
        [EnumMember(Value = "commitmentIdentifier")]
        CommitmentIdentifier,
        [EnumMember(Value = "paymentNumber")]
        PaymentNumber,
        [EnumMember(Value = "accsLine")]
        AccsLine,
        [EnumMember(Value = "fundCode")]
        FundCode,
        [EnumMember(Value = "amount")]
        Amount,
        [EnumMember(Value = "id")]
        Id
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HmaSubapplicationsProjectSiteInventoriesOrderbyInputItem
    {
        [EnumMember(Value = "subapplicationId")]
        SubapplicationId,
        [EnumMember(Value = "subapplicationId desc")]
        SubapplicationIdDesc,
        [EnumMember(Value = "projectSiteInventoryId")]
        ProjectSiteInventoryId,
        [EnumMember(Value = "projectSiteInventoryId desc")]
        ProjectSiteInventoryIdDesc,
        [EnumMember(Value = "projectSiteInventoryType")]
        ProjectSiteInventoryType,
        [EnumMember(Value = "projectSiteInventoryType desc")]
        ProjectSiteInventoryTypeDesc,
        [EnumMember(Value = "primaryActivity")]
        PrimaryActivity,
        [EnumMember(Value = "primaryActivity desc")]
        PrimaryActivityDesc,
        [EnumMember(Value = "secondaryActivity")]
        SecondaryActivity,
        [EnumMember(Value = "secondaryActivity desc")]
        SecondaryActivityDesc,
        [EnumMember(Value = "primaryHazard")]
        PrimaryHazard,
        [EnumMember(Value = "primaryHazard desc")]
        PrimaryHazardDesc,
        [EnumMember(Value = "secondaryHazard")]
        SecondaryHazard,
        [EnumMember(Value = "secondaryHazard desc")]
        SecondaryHazardDesc,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "city desc")]
        CityDesc,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "countyCode desc")]
        CountyCodeDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateCode desc")]
        StateCodeDesc,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "stateAbbreviation desc")]
        StateAbbreviationDesc,
        [EnumMember(Value = "zipcode")]
        Zipcode,
        [EnumMember(Value = "zipcode desc")]
        ZipcodeDesc,
        [EnumMember(Value = "structureType")]
        StructureType,
        [EnumMember(Value = "structureType desc")]
        StructureTypeDesc,
        [EnumMember(Value = "structurePrimarySubtype")]
        StructurePrimarySubtype,
        [EnumMember(Value = "structurePrimarySubtype desc")]
        StructurePrimarySubtypeDesc,
        [EnumMember(Value = "structureSecondarySubtype")]
        StructureSecondarySubtype,
        [EnumMember(Value = "structureSecondarySubtype desc")]
        StructureSecondarySubtypeDesc,
        [EnumMember(Value = "foundationType")]
        FoundationType,
        [EnumMember(Value = "foundationType desc")]
        FoundationTypeDesc,
        [EnumMember(Value = "buildingSize")]
        BuildingSize,
        [EnumMember(Value = "buildingSize desc")]
        BuildingSizeDesc,
        [EnumMember(Value = "lotSize")]
        LotSize,
        [EnumMember(Value = "lotSize desc")]
        LotSizeDesc,
        [EnumMember(Value = "yearBuilt")]
        YearBuilt,
        [EnumMember(Value = "yearBuilt desc")]
        YearBuiltDesc,
        [EnumMember(Value = "firstFloorElevation")]
        FirstFloorElevation,
        [EnumMember(Value = "firstFloorElevation desc")]
        FirstFloorElevationDesc,
        [EnumMember(Value = "feetAboveBaseFloodElevation")]
        FeetAboveBaseFloodElevation,
        [EnumMember(Value = "feetAboveBaseFloodElevation desc")]
        FeetAboveBaseFloodElevationDesc,
        [EnumMember(Value = "baseFloodElevation")]
        BaseFloodElevation,
        [EnumMember(Value = "baseFloodElevation desc")]
        BaseFloodElevationDesc,
        [EnumMember(Value = "floodZone")]
        FloodZone,
        [EnumMember(Value = "floodZone desc")]
        FloodZoneDesc,
        [EnumMember(Value = "estimatedPurchasePrice")]
        EstimatedPurchasePrice,
        [EnumMember(Value = "estimatedPurchasePrice desc")]
        EstimatedPurchasePriceDesc,
        [EnumMember(Value = "proposedLandUse")]
        ProposedLandUse,
        [EnumMember(Value = "proposedLandUse desc")]
        ProposedLandUseDesc,
        [EnumMember(Value = "currentlyRented")]
        CurrentlyRented,
        [EnumMember(Value = "currentlyRented desc")]
        CurrentlyRentedDesc,
        [EnumMember(Value = "criticalFacility")]
        CriticalFacility,
        [EnumMember(Value = "criticalFacility desc")]
        CriticalFacilityDesc,
        [EnumMember(Value = "alternateStructure")]
        AlternateStructure,
        [EnumMember(Value = "alternateStructure desc")]
        AlternateStructureDesc,
        [EnumMember(Value = "substantiallyDamaged")]
        SubstantiallyDamaged,
        [EnumMember(Value = "substantiallyDamaged desc")]
        SubstantiallyDamagedDesc,
        [EnumMember(Value = "publiclyOwned")]
        PubliclyOwned,
        [EnumMember(Value = "publiclyOwned desc")]
        PubliclyOwnedDesc,
        [EnumMember(Value = "insured")]
        Insured,
        [EnumMember(Value = "insured desc")]
        InsuredDesc,
        [EnumMember(Value = "insuranceType")]
        InsuranceType,
        [EnumMember(Value = "insuranceType desc")]
        InsuranceTypeDesc,
        [EnumMember(Value = "repetitiveLossStructure")]
        RepetitiveLossStructure,
        [EnumMember(Value = "repetitiveLossStructure desc")]
        RepetitiveLossStructureDesc,
        [EnumMember(Value = "severeRepetitiveLossStructure")]
        SevereRepetitiveLossStructure,
        [EnumMember(Value = "severeRepetitiveLossStructure desc")]
        SevereRepetitiveLossStructureDesc,
        [EnumMember(Value = "costEffectivenessMethod")]
        CostEffectivenessMethod,
        [EnumMember(Value = "costEffectivenessMethod desc")]
        CostEffectivenessMethodDesc,
        [EnumMember(Value = "preCalculatedBenefit")]
        PreCalculatedBenefit,
        [EnumMember(Value = "preCalculatedBenefit desc")]
        PreCalculatedBenefitDesc,
        [EnumMember(Value = "benefitCostRatio")]
        BenefitCostRatio,
        [EnumMember(Value = "benefitCostRatio desc")]
        BenefitCostRatioDesc,
        [EnumMember(Value = "ownerType")]
        OwnerType,
        [EnumMember(Value = "ownerType desc")]
        OwnerTypeDesc,
        [EnumMember(Value = "coownerType")]
        CoownerType,
        [EnumMember(Value = "coownerType desc")]
        CoownerTypeDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1HmaSubapplicationsProjectSiteInventoriesSelectInputItem
    {
        [EnumMember(Value = "subapplicationId")]
        SubapplicationId,
        [EnumMember(Value = "projectSiteInventoryId")]
        ProjectSiteInventoryId,
        [EnumMember(Value = "projectSiteInventoryType")]
        ProjectSiteInventoryType,
        [EnumMember(Value = "primaryActivity")]
        PrimaryActivity,
        [EnumMember(Value = "secondaryActivity")]
        SecondaryActivity,
        [EnumMember(Value = "primaryHazard")]
        PrimaryHazard,
        [EnumMember(Value = "secondaryHazard")]
        SecondaryHazard,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "zipcode")]
        Zipcode,
        [EnumMember(Value = "structureType")]
        StructureType,
        [EnumMember(Value = "structurePrimarySubtype")]
        StructurePrimarySubtype,
        [EnumMember(Value = "structureSecondarySubtype")]
        StructureSecondarySubtype,
        [EnumMember(Value = "foundationType")]
        FoundationType,
        [EnumMember(Value = "buildingSize")]
        BuildingSize,
        [EnumMember(Value = "lotSize")]
        LotSize,
        [EnumMember(Value = "yearBuilt")]
        YearBuilt,
        [EnumMember(Value = "firstFloorElevation")]
        FirstFloorElevation,
        [EnumMember(Value = "feetAboveBaseFloodElevation")]
        FeetAboveBaseFloodElevation,
        [EnumMember(Value = "baseFloodElevation")]
        BaseFloodElevation,
        [EnumMember(Value = "floodZone")]
        FloodZone,
        [EnumMember(Value = "estimatedPurchasePrice")]
        EstimatedPurchasePrice,
        [EnumMember(Value = "proposedLandUse")]
        ProposedLandUse,
        [EnumMember(Value = "currentlyRented")]
        CurrentlyRented,
        [EnumMember(Value = "criticalFacility")]
        CriticalFacility,
        [EnumMember(Value = "alternateStructure")]
        AlternateStructure,
        [EnumMember(Value = "substantiallyDamaged")]
        SubstantiallyDamaged,
        [EnumMember(Value = "publiclyOwned")]
        PubliclyOwned,
        [EnumMember(Value = "insured")]
        Insured,
        [EnumMember(Value = "insuranceType")]
        InsuranceType,
        [EnumMember(Value = "repetitiveLossStructure")]
        RepetitiveLossStructure,
        [EnumMember(Value = "severeRepetitiveLossStructure")]
        SevereRepetitiveLossStructure,
        [EnumMember(Value = "costEffectivenessMethod")]
        CostEffectivenessMethod,
        [EnumMember(Value = "preCalculatedBenefit")]
        PreCalculatedBenefit,
        [EnumMember(Value = "benefitCostRatio")]
        BenefitCostRatio,
        [EnumMember(Value = "ownerType")]
        OwnerType,
        [EnumMember(Value = "coownerType")]
        CoownerType,
        [EnumMember(Value = "id")]
        Id
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HousingAssistanceOwnersOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "city desc")]
        CityDesc,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "zipCode desc")]
        ZipCodeDesc,
        [EnumMember(Value = "validRegistrations")]
        ValidRegistrations,
        [EnumMember(Value = "validRegistrations desc")]
        ValidRegistrationsDesc,
        [EnumMember(Value = "averageFemaInspectedDamage")]
        AverageFemaInspectedDamage,
        [EnumMember(Value = "averageFemaInspectedDamage desc")]
        AverageFemaInspectedDamageDesc,
        [EnumMember(Value = "totalInspected")]
        TotalInspected,
        [EnumMember(Value = "totalInspected desc")]
        TotalInspectedDesc,
        [EnumMember(Value = "totalDamage")]
        TotalDamage,
        [EnumMember(Value = "totalDamage desc")]
        TotalDamageDesc,
        [EnumMember(Value = "noFemaInspectedDamage")]
        NoFemaInspectedDamage,
        [EnumMember(Value = "noFemaInspectedDamage desc")]
        NoFemaInspectedDamageDesc,
        [EnumMember(Value = "femaInspectedDamageBetween1And10000")]
        FemaInspectedDamageBetween1And10000,
        [EnumMember(Value = "femaInspectedDamageBetween1And10000 desc")]
        FemaInspectedDamageBetween1And10000Desc,
        [EnumMember(Value = "femaInspectedDamageBetween10001And20000")]
        FemaInspectedDamageBetween10001And20000,
        [EnumMember(Value = "femaInspectedDamageBetween10001And20000 desc")]
        FemaInspectedDamageBetween10001And20000Desc,
        [EnumMember(Value = "femaInspectedDamageBetween20001And30000")]
        FemaInspectedDamageBetween20001And30000,
        [EnumMember(Value = "femaInspectedDamageBetween20001And30000 desc")]
        FemaInspectedDamageBetween20001And30000Desc,
        [EnumMember(Value = "femaInspectedDamageGreaterThan30000")]
        FemaInspectedDamageGreaterThan30000,
        [EnumMember(Value = "femaInspectedDamageGreaterThan30000 desc")]
        FemaInspectedDamageGreaterThan30000Desc,
        [EnumMember(Value = "approvedForFemaAssistance")]
        ApprovedForFemaAssistance,
        [EnumMember(Value = "approvedForFemaAssistance desc")]
        ApprovedForFemaAssistanceDesc,
        [EnumMember(Value = "totalApprovedIhpAmount")]
        TotalApprovedIhpAmount,
        [EnumMember(Value = "totalApprovedIhpAmount desc")]
        TotalApprovedIhpAmountDesc,
        [EnumMember(Value = "repairReplaceAmount")]
        RepairReplaceAmount,
        [EnumMember(Value = "repairReplaceAmount desc")]
        RepairReplaceAmountDesc,
        [EnumMember(Value = "rentalAmount")]
        RentalAmount,
        [EnumMember(Value = "rentalAmount desc")]
        RentalAmountDesc,
        [EnumMember(Value = "otherNeedsAmount")]
        OtherNeedsAmount,
        [EnumMember(Value = "otherNeedsAmount desc")]
        OtherNeedsAmountDesc,
        [EnumMember(Value = "approvedBetween1And10000")]
        ApprovedBetween1And10000,
        [EnumMember(Value = "approvedBetween1And10000 desc")]
        ApprovedBetween1And10000Desc,
        [EnumMember(Value = "approvedBetween10001And25000")]
        ApprovedBetween10001And25000,
        [EnumMember(Value = "approvedBetween10001And25000 desc")]
        ApprovedBetween10001And25000Desc,
        [EnumMember(Value = "approvedBetween25001AndMax")]
        ApprovedBetween25001AndMax,
        [EnumMember(Value = "approvedBetween25001AndMax desc")]
        ApprovedBetween25001AndMaxDesc,
        [EnumMember(Value = "totalMaxGrants")]
        TotalMaxGrants,
        [EnumMember(Value = "totalMaxGrants desc")]
        TotalMaxGrantsDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HousingAssistanceOwnersSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "validRegistrations")]
        ValidRegistrations,
        [EnumMember(Value = "averageFemaInspectedDamage")]
        AverageFemaInspectedDamage,
        [EnumMember(Value = "totalInspected")]
        TotalInspected,
        [EnumMember(Value = "totalDamage")]
        TotalDamage,
        [EnumMember(Value = "noFemaInspectedDamage")]
        NoFemaInspectedDamage,
        [EnumMember(Value = "femaInspectedDamageBetween1And10000")]
        FemaInspectedDamageBetween1And10000,
        [EnumMember(Value = "femaInspectedDamageBetween10001And20000")]
        FemaInspectedDamageBetween10001And20000,
        [EnumMember(Value = "femaInspectedDamageBetween20001And30000")]
        FemaInspectedDamageBetween20001And30000,
        [EnumMember(Value = "femaInspectedDamageGreaterThan30000")]
        FemaInspectedDamageGreaterThan30000,
        [EnumMember(Value = "approvedForFemaAssistance")]
        ApprovedForFemaAssistance,
        [EnumMember(Value = "totalApprovedIhpAmount")]
        TotalApprovedIhpAmount,
        [EnumMember(Value = "repairReplaceAmount")]
        RepairReplaceAmount,
        [EnumMember(Value = "rentalAmount")]
        RentalAmount,
        [EnumMember(Value = "otherNeedsAmount")]
        OtherNeedsAmount,
        [EnumMember(Value = "approvedBetween1And10000")]
        ApprovedBetween1And10000,
        [EnumMember(Value = "approvedBetween10001And25000")]
        ApprovedBetween10001And25000,
        [EnumMember(Value = "approvedBetween25001AndMax")]
        ApprovedBetween25001AndMax,
        [EnumMember(Value = "totalMaxGrants")]
        TotalMaxGrants
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HousingAssistanceRentersOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "city desc")]
        CityDesc,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "zipCode desc")]
        ZipCodeDesc,
        [EnumMember(Value = "validRegistrations")]
        ValidRegistrations,
        [EnumMember(Value = "validRegistrations desc")]
        ValidRegistrationsDesc,
        [EnumMember(Value = "totalInspected")]
        TotalInspected,
        [EnumMember(Value = "totalInspected desc")]
        TotalInspectedDesc,
        [EnumMember(Value = "totalInspectedWithNoDamage")]
        TotalInspectedWithNoDamage,
        [EnumMember(Value = "totalInspectedWithNoDamage desc")]
        TotalInspectedWithNoDamageDesc,
        [EnumMember(Value = "totalWithModerateDamage")]
        TotalWithModerateDamage,
        [EnumMember(Value = "totalWithModerateDamage desc")]
        TotalWithModerateDamageDesc,
        [EnumMember(Value = "totalWithMajorDamage")]
        TotalWithMajorDamage,
        [EnumMember(Value = "totalWithMajorDamage desc")]
        TotalWithMajorDamageDesc,
        [EnumMember(Value = "totalWithSubstantialDamage")]
        TotalWithSubstantialDamage,
        [EnumMember(Value = "totalWithSubstantialDamage desc")]
        TotalWithSubstantialDamageDesc,
        [EnumMember(Value = "approvedForFemaAssistance")]
        ApprovedForFemaAssistance,
        [EnumMember(Value = "approvedForFemaAssistance desc")]
        ApprovedForFemaAssistanceDesc,
        [EnumMember(Value = "totalApprovedIhpAmount")]
        TotalApprovedIhpAmount,
        [EnumMember(Value = "totalApprovedIhpAmount desc")]
        TotalApprovedIhpAmountDesc,
        [EnumMember(Value = "repairReplaceAmount")]
        RepairReplaceAmount,
        [EnumMember(Value = "repairReplaceAmount desc")]
        RepairReplaceAmountDesc,
        [EnumMember(Value = "rentalAmount")]
        RentalAmount,
        [EnumMember(Value = "rentalAmount desc")]
        RentalAmountDesc,
        [EnumMember(Value = "otherNeedsAmount")]
        OtherNeedsAmount,
        [EnumMember(Value = "otherNeedsAmount desc")]
        OtherNeedsAmountDesc,
        [EnumMember(Value = "approvedBetween1And10000")]
        ApprovedBetween1And10000,
        [EnumMember(Value = "approvedBetween1And10000 desc")]
        ApprovedBetween1And10000Desc,
        [EnumMember(Value = "approvedBetween10001And25000")]
        ApprovedBetween10001And25000,
        [EnumMember(Value = "approvedBetween10001And25000 desc")]
        ApprovedBetween10001And25000Desc,
        [EnumMember(Value = "approvedBetween25001AndMax")]
        ApprovedBetween25001AndMax,
        [EnumMember(Value = "approvedBetween25001AndMax desc")]
        ApprovedBetween25001AndMaxDesc,
        [EnumMember(Value = "totalMaxGrants")]
        TotalMaxGrants,
        [EnumMember(Value = "totalMaxGrants desc")]
        TotalMaxGrantsDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2HousingAssistanceRentersSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "validRegistrations")]
        ValidRegistrations,
        [EnumMember(Value = "totalInspected")]
        TotalInspected,
        [EnumMember(Value = "totalInspectedWithNoDamage")]
        TotalInspectedWithNoDamage,
        [EnumMember(Value = "totalWithModerateDamage")]
        TotalWithModerateDamage,
        [EnumMember(Value = "totalWithMajorDamage")]
        TotalWithMajorDamage,
        [EnumMember(Value = "totalWithSubstantialDamage")]
        TotalWithSubstantialDamage,
        [EnumMember(Value = "approvedForFemaAssistance")]
        ApprovedForFemaAssistance,
        [EnumMember(Value = "totalApprovedIhpAmount")]
        TotalApprovedIhpAmount,
        [EnumMember(Value = "repairReplaceAmount")]
        RepairReplaceAmount,
        [EnumMember(Value = "rentalAmount")]
        RentalAmount,
        [EnumMember(Value = "otherNeedsAmount")]
        OtherNeedsAmount,
        [EnumMember(Value = "approvedBetween1And10000")]
        ApprovedBetween1And10000,
        [EnumMember(Value = "approvedBetween10001And25000")]
        ApprovedBetween10001And25000,
        [EnumMember(Value = "approvedBetween25001AndMax")]
        ApprovedBetween25001AndMax,
        [EnumMember(Value = "totalMaxGrants")]
        TotalMaxGrants
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1IndividualAssistanceHousingRegistrantsLargeDisastersOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "damagedCity")]
        DamagedCity,
        [EnumMember(Value = "damagedCity desc")]
        DamagedCityDesc,
        [EnumMember(Value = "damagedStateAbbreviation")]
        DamagedStateAbbreviation,
        [EnumMember(Value = "damagedStateAbbreviation desc")]
        DamagedStateAbbreviationDesc,
        [EnumMember(Value = "damagedZipCode")]
        DamagedZipCode,
        [EnumMember(Value = "damagedZipCode desc")]
        DamagedZipCodeDesc,
        [EnumMember(Value = "householdComposition")]
        HouseholdComposition,
        [EnumMember(Value = "householdComposition desc")]
        HouseholdCompositionDesc,
        [EnumMember(Value = "grossIncome")]
        GrossIncome,
        [EnumMember(Value = "grossIncome desc")]
        GrossIncomeDesc,
        [EnumMember(Value = "specialNeeds")]
        SpecialNeeds,
        [EnumMember(Value = "specialNeeds desc")]
        SpecialNeedsDesc,
        [EnumMember(Value = "ownRent")]
        OwnRent,
        [EnumMember(Value = "ownRent desc")]
        OwnRentDesc,
        [EnumMember(Value = "residenceType")]
        ResidenceType,
        [EnumMember(Value = "residenceType desc")]
        ResidenceTypeDesc,
        [EnumMember(Value = "homeOwnersInsurance")]
        HomeOwnersInsurance,
        [EnumMember(Value = "homeOwnersInsurance desc")]
        HomeOwnersInsuranceDesc,
        [EnumMember(Value = "floodInsurance")]
        FloodInsurance,
        [EnumMember(Value = "floodInsurance desc")]
        FloodInsuranceDesc,
        [EnumMember(Value = "inspected")]
        Inspected,
        [EnumMember(Value = "inspected desc")]
        InspectedDesc,
        [EnumMember(Value = "rpfvl")]
        Rpfvl,
        [EnumMember(Value = "rpfvl desc")]
        RpfvlDesc,
        [EnumMember(Value = "habitabilityRepairsRequired")]
        HabitabilityRepairsRequired,
        [EnumMember(Value = "habitabilityRepairsRequired desc")]
        HabitabilityRepairsRequiredDesc,
        [EnumMember(Value = "destroyed")]
        Destroyed,
        [EnumMember(Value = "destroyed desc")]
        DestroyedDesc,
        [EnumMember(Value = "waterLevel")]
        WaterLevel,
        [EnumMember(Value = "waterLevel desc")]
        WaterLevelDesc,
        [EnumMember(Value = "highWaterLocation")]
        HighWaterLocation,
        [EnumMember(Value = "highWaterLocation desc")]
        HighWaterLocationDesc,
        [EnumMember(Value = "floodDamage")]
        FloodDamage,
        [EnumMember(Value = "floodDamage desc")]
        FloodDamageDesc,
        [EnumMember(Value = "foundationDamage")]
        FoundationDamage,
        [EnumMember(Value = "foundationDamage desc")]
        FoundationDamageDesc,
        [EnumMember(Value = "foundationDamageAmount")]
        FoundationDamageAmount,
        [EnumMember(Value = "foundationDamageAmount desc")]
        FoundationDamageAmountDesc,
        [EnumMember(Value = "roofDamage")]
        RoofDamage,
        [EnumMember(Value = "roofDamage desc")]
        RoofDamageDesc,
        [EnumMember(Value = "roofDamageAmount")]
        RoofDamageAmount,
        [EnumMember(Value = "roofDamageAmount desc")]
        RoofDamageAmountDesc,
        [EnumMember(Value = "tsaEligible")]
        TsaEligible,
        [EnumMember(Value = "tsaEligible desc")]
        TsaEligibleDesc,
        [EnumMember(Value = "tsaCheckedIn")]
        TsaCheckedIn,
        [EnumMember(Value = "tsaCheckedIn desc")]
        TsaCheckedInDesc,
        [EnumMember(Value = "rentalAssistanceEligible")]
        RentalAssistanceEligible,
        [EnumMember(Value = "rentalAssistanceEligible desc")]
        RentalAssistanceEligibleDesc,
        [EnumMember(Value = "rentalAssistanceAmount")]
        RentalAssistanceAmount,
        [EnumMember(Value = "rentalAssistanceAmount desc")]
        RentalAssistanceAmountDesc,
        [EnumMember(Value = "repairAssistanceEligible")]
        RepairAssistanceEligible,
        [EnumMember(Value = "repairAssistanceEligible desc")]
        RepairAssistanceEligibleDesc,
        [EnumMember(Value = "repairAmount")]
        RepairAmount,
        [EnumMember(Value = "repairAmount desc")]
        RepairAmountDesc,
        [EnumMember(Value = "replacementAssistanceEligible")]
        ReplacementAssistanceEligible,
        [EnumMember(Value = "replacementAssistanceEligible desc")]
        ReplacementAssistanceEligibleDesc,
        [EnumMember(Value = "replacementAmount")]
        ReplacementAmount,
        [EnumMember(Value = "replacementAmount desc")]
        ReplacementAmountDesc,
        [EnumMember(Value = "sbaEligible")]
        SbaEligible,
        [EnumMember(Value = "sbaEligible desc")]
        SbaEligibleDesc,
        [EnumMember(Value = "renterDamageLevel")]
        RenterDamageLevel,
        [EnumMember(Value = "renterDamageLevel desc")]
        RenterDamageLevelDesc,
        [EnumMember(Value = "rentalAssistanceEndDate")]
        RentalAssistanceEndDate,
        [EnumMember(Value = "rentalAssistanceEndDate desc")]
        RentalAssistanceEndDateDesc,
        [EnumMember(Value = "rentalResourceCity")]
        RentalResourceCity,
        [EnumMember(Value = "rentalResourceCity desc")]
        RentalResourceCityDesc,
        [EnumMember(Value = "rentalResourceStateAbbreviation")]
        RentalResourceStateAbbreviation,
        [EnumMember(Value = "rentalResourceStateAbbreviation desc")]
        RentalResourceStateAbbreviationDesc,
        [EnumMember(Value = "rentalResourceZipCode")]
        RentalResourceZipCode,
        [EnumMember(Value = "rentalResourceZipCode desc")]
        RentalResourceZipCodeDesc,
        [EnumMember(Value = "primaryResidence")]
        PrimaryResidence,
        [EnumMember(Value = "primaryResidence desc")]
        PrimaryResidenceDesc,
        [EnumMember(Value = "personalPropertyEligible")]
        PersonalPropertyEligible,
        [EnumMember(Value = "personalPropertyEligible desc")]
        PersonalPropertyEligibleDesc,
        [EnumMember(Value = "ppfvl")]
        Ppfvl,
        [EnumMember(Value = "ppfvl desc")]
        PpfvlDesc,
        [EnumMember(Value = "censusBlockId")]
        CensusBlockId,
        [EnumMember(Value = "censusBlockId desc")]
        CensusBlockIdDesc,
        [EnumMember(Value = "censusYear")]
        CensusYear,
        [EnumMember(Value = "censusYear desc")]
        CensusYearDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1IndividualAssistanceHousingRegistrantsLargeDisastersSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "damagedCity")]
        DamagedCity,
        [EnumMember(Value = "damagedStateAbbreviation")]
        DamagedStateAbbreviation,
        [EnumMember(Value = "damagedZipCode")]
        DamagedZipCode,
        [EnumMember(Value = "householdComposition")]
        HouseholdComposition,
        [EnumMember(Value = "grossIncome")]
        GrossIncome,
        [EnumMember(Value = "specialNeeds")]
        SpecialNeeds,
        [EnumMember(Value = "ownRent")]
        OwnRent,
        [EnumMember(Value = "residenceType")]
        ResidenceType,
        [EnumMember(Value = "homeOwnersInsurance")]
        HomeOwnersInsurance,
        [EnumMember(Value = "floodInsurance")]
        FloodInsurance,
        [EnumMember(Value = "inspected")]
        Inspected,
        [EnumMember(Value = "rpfvl")]
        Rpfvl,
        [EnumMember(Value = "habitabilityRepairsRequired")]
        HabitabilityRepairsRequired,
        [EnumMember(Value = "destroyed")]
        Destroyed,
        [EnumMember(Value = "waterLevel")]
        WaterLevel,
        [EnumMember(Value = "highWaterLocation")]
        HighWaterLocation,
        [EnumMember(Value = "floodDamage")]
        FloodDamage,
        [EnumMember(Value = "foundationDamage")]
        FoundationDamage,
        [EnumMember(Value = "foundationDamageAmount")]
        FoundationDamageAmount,
        [EnumMember(Value = "roofDamage")]
        RoofDamage,
        [EnumMember(Value = "roofDamageAmount")]
        RoofDamageAmount,
        [EnumMember(Value = "tsaEligible")]
        TsaEligible,
        [EnumMember(Value = "tsaCheckedIn")]
        TsaCheckedIn,
        [EnumMember(Value = "rentalAssistanceEligible")]
        RentalAssistanceEligible,
        [EnumMember(Value = "rentalAssistanceAmount")]
        RentalAssistanceAmount,
        [EnumMember(Value = "repairAssistanceEligible")]
        RepairAssistanceEligible,
        [EnumMember(Value = "repairAmount")]
        RepairAmount,
        [EnumMember(Value = "replacementAssistanceEligible")]
        ReplacementAssistanceEligible,
        [EnumMember(Value = "replacementAmount")]
        ReplacementAmount,
        [EnumMember(Value = "sbaEligible")]
        SbaEligible,
        [EnumMember(Value = "renterDamageLevel")]
        RenterDamageLevel,
        [EnumMember(Value = "rentalAssistanceEndDate")]
        RentalAssistanceEndDate,
        [EnumMember(Value = "rentalResourceCity")]
        RentalResourceCity,
        [EnumMember(Value = "rentalResourceStateAbbreviation")]
        RentalResourceStateAbbreviation,
        [EnumMember(Value = "rentalResourceZipCode")]
        RentalResourceZipCode,
        [EnumMember(Value = "primaryResidence")]
        PrimaryResidence,
        [EnumMember(Value = "personalPropertyEligible")]
        PersonalPropertyEligible,
        [EnumMember(Value = "ppfvl")]
        Ppfvl,
        [EnumMember(Value = "censusBlockId")]
        CensusBlockId,
        [EnumMember(Value = "censusYear")]
        CensusYear
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1IndividualsAndHouseholdsProgramValidRegistrationsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "incidentType desc")]
        IncidentTypeDesc,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "declarationDate desc")]
        DeclarationDateDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "damagedStateAbbreviation")]
        DamagedStateAbbreviation,
        [EnumMember(Value = "damagedStateAbbreviation desc")]
        DamagedStateAbbreviationDesc,
        [EnumMember(Value = "damagedCity")]
        DamagedCity,
        [EnumMember(Value = "damagedCity desc")]
        DamagedCityDesc,
        [EnumMember(Value = "damagedZipCode")]
        DamagedZipCode,
        [EnumMember(Value = "damagedZipCode desc")]
        DamagedZipCodeDesc,
        [EnumMember(Value = "applicantAge")]
        ApplicantAge,
        [EnumMember(Value = "applicantAge desc")]
        ApplicantAgeDesc,
        [EnumMember(Value = "householdComposition")]
        HouseholdComposition,
        [EnumMember(Value = "householdComposition desc")]
        HouseholdCompositionDesc,
        [EnumMember(Value = "occupantsUnderTwo")]
        OccupantsUnderTwo,
        [EnumMember(Value = "occupantsUnderTwo desc")]
        OccupantsUnderTwoDesc,
        [EnumMember(Value = "occupants2to5")]
        Occupants2to5,
        [EnumMember(Value = "occupants2to5 desc")]
        Occupants2to5Desc,
        [EnumMember(Value = "occupants6to18")]
        Occupants6to18,
        [EnumMember(Value = "occupants6to18 desc")]
        Occupants6to18Desc,
        [EnumMember(Value = "occupants19to64")]
        Occupants19to64,
        [EnumMember(Value = "occupants19to64 desc")]
        Occupants19to64Desc,
        [EnumMember(Value = "occupants65andOver")]
        Occupants65andOver,
        [EnumMember(Value = "occupants65andOver desc")]
        Occupants65andOverDesc,
        [EnumMember(Value = "grossIncome")]
        GrossIncome,
        [EnumMember(Value = "grossIncome desc")]
        GrossIncomeDesc,
        [EnumMember(Value = "ownRent")]
        OwnRent,
        [EnumMember(Value = "ownRent desc")]
        OwnRentDesc,
        [EnumMember(Value = "primaryResidence")]
        PrimaryResidence,
        [EnumMember(Value = "primaryResidence desc")]
        PrimaryResidenceDesc,
        [EnumMember(Value = "residenceType")]
        ResidenceType,
        [EnumMember(Value = "residenceType desc")]
        ResidenceTypeDesc,
        [EnumMember(Value = "homeOwnersInsurance")]
        HomeOwnersInsurance,
        [EnumMember(Value = "homeOwnersInsurance desc")]
        HomeOwnersInsuranceDesc,
        [EnumMember(Value = "floodInsurance")]
        FloodInsurance,
        [EnumMember(Value = "floodInsurance desc")]
        FloodInsuranceDesc,
        [EnumMember(Value = "registrationMethod")]
        RegistrationMethod,
        [EnumMember(Value = "registrationMethod desc")]
        RegistrationMethodDesc,
        [EnumMember(Value = "ihpReferral")]
        IhpReferral,
        [EnumMember(Value = "ihpReferral desc")]
        IhpReferralDesc,
        [EnumMember(Value = "ihpEligible")]
        IhpEligible,
        [EnumMember(Value = "ihpEligible desc")]
        IhpEligibleDesc,
        [EnumMember(Value = "ihpAmount")]
        IhpAmount,
        [EnumMember(Value = "ihpAmount desc")]
        IhpAmountDesc,
        [EnumMember(Value = "fipAmount")]
        FipAmount,
        [EnumMember(Value = "fipAmount desc")]
        FipAmountDesc,
        [EnumMember(Value = "haReferral")]
        HaReferral,
        [EnumMember(Value = "haReferral desc")]
        HaReferralDesc,
        [EnumMember(Value = "haEligible")]
        HaEligible,
        [EnumMember(Value = "haEligible desc")]
        HaEligibleDesc,
        [EnumMember(Value = "haAmount")]
        HaAmount,
        [EnumMember(Value = "haAmount desc")]
        HaAmountDesc,
        [EnumMember(Value = "haStatus")]
        HaStatus,
        [EnumMember(Value = "haStatus desc")]
        HaStatusDesc,
        [EnumMember(Value = "onaReferral")]
        OnaReferral,
        [EnumMember(Value = "onaReferral desc")]
        OnaReferralDesc,
        [EnumMember(Value = "onaEligible")]
        OnaEligible,
        [EnumMember(Value = "onaEligible desc")]
        OnaEligibleDesc,
        [EnumMember(Value = "onaAmount")]
        OnaAmount,
        [EnumMember(Value = "onaAmount desc")]
        OnaAmountDesc,
        [EnumMember(Value = "utilitiesOut")]
        UtilitiesOut,
        [EnumMember(Value = "utilitiesOut desc")]
        UtilitiesOutDesc,
        [EnumMember(Value = "homeDamage")]
        HomeDamage,
        [EnumMember(Value = "homeDamage desc")]
        HomeDamageDesc,
        [EnumMember(Value = "autoDamage")]
        AutoDamage,
        [EnumMember(Value = "autoDamage desc")]
        AutoDamageDesc,
        [EnumMember(Value = "emergencyNeeds")]
        EmergencyNeeds,
        [EnumMember(Value = "emergencyNeeds desc")]
        EmergencyNeedsDesc,
        [EnumMember(Value = "foodNeed")]
        FoodNeed,
        [EnumMember(Value = "foodNeed desc")]
        FoodNeedDesc,
        [EnumMember(Value = "shelterNeed")]
        ShelterNeed,
        [EnumMember(Value = "shelterNeed desc")]
        ShelterNeedDesc,
        [EnumMember(Value = "accessFunctionalNeeds")]
        AccessFunctionalNeeds,
        [EnumMember(Value = "accessFunctionalNeeds desc")]
        AccessFunctionalNeedsDesc,
        [EnumMember(Value = "sbaEligible")]
        SbaEligible,
        [EnumMember(Value = "sbaEligible desc")]
        SbaEligibleDesc,
        [EnumMember(Value = "sbaApproved")]
        SbaApproved,
        [EnumMember(Value = "sbaApproved desc")]
        SbaApprovedDesc,
        [EnumMember(Value = "inspnIssued")]
        InspnIssued,
        [EnumMember(Value = "inspnIssued desc")]
        InspnIssuedDesc,
        [EnumMember(Value = "inspnReturned")]
        InspnReturned,
        [EnumMember(Value = "inspnReturned desc")]
        InspnReturnedDesc,
        [EnumMember(Value = "habitabilityRepairsRequired")]
        HabitabilityRepairsRequired,
        [EnumMember(Value = "habitabilityRepairsRequired desc")]
        HabitabilityRepairsRequiredDesc,
        [EnumMember(Value = "rpfvl")]
        Rpfvl,
        [EnumMember(Value = "rpfvl desc")]
        RpfvlDesc,
        [EnumMember(Value = "ppfvl")]
        Ppfvl,
        [EnumMember(Value = "ppfvl desc")]
        PpfvlDesc,
        [EnumMember(Value = "renterDamageLevel")]
        RenterDamageLevel,
        [EnumMember(Value = "renterDamageLevel desc")]
        RenterDamageLevelDesc,
        [EnumMember(Value = "destroyed")]
        Destroyed,
        [EnumMember(Value = "destroyed desc")]
        DestroyedDesc,
        [EnumMember(Value = "waterLevel")]
        WaterLevel,
        [EnumMember(Value = "waterLevel desc")]
        WaterLevelDesc,
        [EnumMember(Value = "highWaterLocation")]
        HighWaterLocation,
        [EnumMember(Value = "highWaterLocation desc")]
        HighWaterLocationDesc,
        [EnumMember(Value = "floodDamage")]
        FloodDamage,
        [EnumMember(Value = "floodDamage desc")]
        FloodDamageDesc,
        [EnumMember(Value = "floodDamageAmount")]
        FloodDamageAmount,
        [EnumMember(Value = "floodDamageAmount desc")]
        FloodDamageAmountDesc,
        [EnumMember(Value = "foundationDamage")]
        FoundationDamage,
        [EnumMember(Value = "foundationDamage desc")]
        FoundationDamageDesc,
        [EnumMember(Value = "foundationDamageAmount")]
        FoundationDamageAmount,
        [EnumMember(Value = "foundationDamageAmount desc")]
        FoundationDamageAmountDesc,
        [EnumMember(Value = "roofDamage")]
        RoofDamage,
        [EnumMember(Value = "roofDamage desc")]
        RoofDamageDesc,
        [EnumMember(Value = "roofDamageAmount")]
        RoofDamageAmount,
        [EnumMember(Value = "roofDamageAmount desc")]
        RoofDamageAmountDesc,
        [EnumMember(Value = "tsaEligible")]
        TsaEligible,
        [EnumMember(Value = "tsaEligible desc")]
        TsaEligibleDesc,
        [EnumMember(Value = "tsaCheckedIn")]
        TsaCheckedIn,
        [EnumMember(Value = "tsaCheckedIn desc")]
        TsaCheckedInDesc,
        [EnumMember(Value = "rentalAssistanceEligible")]
        RentalAssistanceEligible,
        [EnumMember(Value = "rentalAssistanceEligible desc")]
        RentalAssistanceEligibleDesc,
        [EnumMember(Value = "rentalAssistanceAmount")]
        RentalAssistanceAmount,
        [EnumMember(Value = "rentalAssistanceAmount desc")]
        RentalAssistanceAmountDesc,
        [EnumMember(Value = "repairAssistanceEligible")]
        RepairAssistanceEligible,
        [EnumMember(Value = "repairAssistanceEligible desc")]
        RepairAssistanceEligibleDesc,
        [EnumMember(Value = "repairAmount")]
        RepairAmount,
        [EnumMember(Value = "repairAmount desc")]
        RepairAmountDesc,
        [EnumMember(Value = "replacementAssistanceEligible")]
        ReplacementAssistanceEligible,
        [EnumMember(Value = "replacementAssistanceEligible desc")]
        ReplacementAssistanceEligibleDesc,
        [EnumMember(Value = "replacementAmount")]
        ReplacementAmount,
        [EnumMember(Value = "replacementAmount desc")]
        ReplacementAmountDesc,
        [EnumMember(Value = "personalPropertyEligible")]
        PersonalPropertyEligible,
        [EnumMember(Value = "personalPropertyEligible desc")]
        PersonalPropertyEligibleDesc,
        [EnumMember(Value = "personalPropertyAmount")]
        PersonalPropertyAmount,
        [EnumMember(Value = "personalPropertyAmount desc")]
        PersonalPropertyAmountDesc,
        [EnumMember(Value = "ihpMax")]
        IhpMax,
        [EnumMember(Value = "ihpMax desc")]
        IhpMaxDesc,
        [EnumMember(Value = "haMax")]
        HaMax,
        [EnumMember(Value = "haMax desc")]
        HaMaxDesc,
        [EnumMember(Value = "onaMax")]
        OnaMax,
        [EnumMember(Value = "onaMax desc")]
        OnaMaxDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1IndividualsAndHouseholdsProgramValidRegistrationsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "damagedStateAbbreviation")]
        DamagedStateAbbreviation,
        [EnumMember(Value = "damagedCity")]
        DamagedCity,
        [EnumMember(Value = "damagedZipCode")]
        DamagedZipCode,
        [EnumMember(Value = "applicantAge")]
        ApplicantAge,
        [EnumMember(Value = "householdComposition")]
        HouseholdComposition,
        [EnumMember(Value = "occupantsUnderTwo")]
        OccupantsUnderTwo,
        [EnumMember(Value = "occupants2to5")]
        Occupants2to5,
        [EnumMember(Value = "occupants6to18")]
        Occupants6to18,
        [EnumMember(Value = "occupants19to64")]
        Occupants19to64,
        [EnumMember(Value = "occupants65andOver")]
        Occupants65andOver,
        [EnumMember(Value = "grossIncome")]
        GrossIncome,
        [EnumMember(Value = "ownRent")]
        OwnRent,
        [EnumMember(Value = "primaryResidence")]
        PrimaryResidence,
        [EnumMember(Value = "residenceType")]
        ResidenceType,
        [EnumMember(Value = "homeOwnersInsurance")]
        HomeOwnersInsurance,
        [EnumMember(Value = "floodInsurance")]
        FloodInsurance,
        [EnumMember(Value = "registrationMethod")]
        RegistrationMethod,
        [EnumMember(Value = "ihpReferral")]
        IhpReferral,
        [EnumMember(Value = "ihpEligible")]
        IhpEligible,
        [EnumMember(Value = "ihpAmount")]
        IhpAmount,
        [EnumMember(Value = "fipAmount")]
        FipAmount,
        [EnumMember(Value = "haReferral")]
        HaReferral,
        [EnumMember(Value = "haEligible")]
        HaEligible,
        [EnumMember(Value = "haAmount")]
        HaAmount,
        [EnumMember(Value = "haStatus")]
        HaStatus,
        [EnumMember(Value = "onaReferral")]
        OnaReferral,
        [EnumMember(Value = "onaEligible")]
        OnaEligible,
        [EnumMember(Value = "onaAmount")]
        OnaAmount,
        [EnumMember(Value = "utilitiesOut")]
        UtilitiesOut,
        [EnumMember(Value = "homeDamage")]
        HomeDamage,
        [EnumMember(Value = "autoDamage")]
        AutoDamage,
        [EnumMember(Value = "emergencyNeeds")]
        EmergencyNeeds,
        [EnumMember(Value = "foodNeed")]
        FoodNeed,
        [EnumMember(Value = "shelterNeed")]
        ShelterNeed,
        [EnumMember(Value = "accessFunctionalNeeds")]
        AccessFunctionalNeeds,
        [EnumMember(Value = "sbaEligible")]
        SbaEligible,
        [EnumMember(Value = "sbaApproved")]
        SbaApproved,
        [EnumMember(Value = "inspnIssued")]
        InspnIssued,
        [EnumMember(Value = "inspnReturned")]
        InspnReturned,
        [EnumMember(Value = "habitabilityRepairsRequired")]
        HabitabilityRepairsRequired,
        [EnumMember(Value = "rpfvl")]
        Rpfvl,
        [EnumMember(Value = "ppfvl")]
        Ppfvl,
        [EnumMember(Value = "renterDamageLevel")]
        RenterDamageLevel,
        [EnumMember(Value = "destroyed")]
        Destroyed,
        [EnumMember(Value = "waterLevel")]
        WaterLevel,
        [EnumMember(Value = "highWaterLocation")]
        HighWaterLocation,
        [EnumMember(Value = "floodDamage")]
        FloodDamage,
        [EnumMember(Value = "floodDamageAmount")]
        FloodDamageAmount,
        [EnumMember(Value = "foundationDamage")]
        FoundationDamage,
        [EnumMember(Value = "foundationDamageAmount")]
        FoundationDamageAmount,
        [EnumMember(Value = "roofDamage")]
        RoofDamage,
        [EnumMember(Value = "roofDamageAmount")]
        RoofDamageAmount,
        [EnumMember(Value = "tsaEligible")]
        TsaEligible,
        [EnumMember(Value = "tsaCheckedIn")]
        TsaCheckedIn,
        [EnumMember(Value = "rentalAssistanceEligible")]
        RentalAssistanceEligible,
        [EnumMember(Value = "rentalAssistanceAmount")]
        RentalAssistanceAmount,
        [EnumMember(Value = "repairAssistanceEligible")]
        RepairAssistanceEligible,
        [EnumMember(Value = "repairAmount")]
        RepairAmount,
        [EnumMember(Value = "replacementAssistanceEligible")]
        ReplacementAssistanceEligible,
        [EnumMember(Value = "replacementAmount")]
        ReplacementAmount,
        [EnumMember(Value = "personalPropertyEligible")]
        PersonalPropertyEligible,
        [EnumMember(Value = "personalPropertyAmount")]
        PersonalPropertyAmount,
        [EnumMember(Value = "ihpMax")]
        IhpMax,
        [EnumMember(Value = "haMax")]
        HaMax,
        [EnumMember(Value = "onaMax")]
        OnaMax,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2RegistrationIntakeIndividualsHouseholdProgramsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "city desc")]
        CityDesc,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "zipCode desc")]
        ZipCodeDesc,
        [EnumMember(Value = "totalValidRegistrations")]
        TotalValidRegistrations,
        [EnumMember(Value = "totalValidRegistrations desc")]
        TotalValidRegistrationsDesc,
        [EnumMember(Value = "validCallCenterRegistrations")]
        ValidCallCenterRegistrations,
        [EnumMember(Value = "validCallCenterRegistrations desc")]
        ValidCallCenterRegistrationsDesc,
        [EnumMember(Value = "validWebRegistrations")]
        ValidWebRegistrations,
        [EnumMember(Value = "validWebRegistrations desc")]
        ValidWebRegistrationsDesc,
        [EnumMember(Value = "validMobileRegistrations")]
        ValidMobileRegistrations,
        [EnumMember(Value = "validMobileRegistrations desc")]
        ValidMobileRegistrationsDesc,
        [EnumMember(Value = "ihpReferrals")]
        IhpReferrals,
        [EnumMember(Value = "ihpReferrals desc")]
        IhpReferralsDesc,
        [EnumMember(Value = "ihpEligible")]
        IhpEligible,
        [EnumMember(Value = "ihpEligible desc")]
        IhpEligibleDesc,
        [EnumMember(Value = "ihpAmount")]
        IhpAmount,
        [EnumMember(Value = "ihpAmount desc")]
        IhpAmountDesc,
        [EnumMember(Value = "haReferrals")]
        HaReferrals,
        [EnumMember(Value = "haReferrals desc")]
        HaReferralsDesc,
        [EnumMember(Value = "haEligible")]
        HaEligible,
        [EnumMember(Value = "haEligible desc")]
        HaEligibleDesc,
        [EnumMember(Value = "haAmount")]
        HaAmount,
        [EnumMember(Value = "haAmount desc")]
        HaAmountDesc,
        [EnumMember(Value = "onaReferrals")]
        OnaReferrals,
        [EnumMember(Value = "onaReferrals desc")]
        OnaReferralsDesc,
        [EnumMember(Value = "onaEligible")]
        OnaEligible,
        [EnumMember(Value = "onaEligible desc")]
        OnaEligibleDesc,
        [EnumMember(Value = "onaAmount")]
        OnaAmount,
        [EnumMember(Value = "onaAmount desc")]
        OnaAmountDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2RegistrationIntakeIndividualsHouseholdProgramsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "totalValidRegistrations")]
        TotalValidRegistrations,
        [EnumMember(Value = "validCallCenterRegistrations")]
        ValidCallCenterRegistrations,
        [EnumMember(Value = "validWebRegistrations")]
        ValidWebRegistrations,
        [EnumMember(Value = "validMobileRegistrations")]
        ValidMobileRegistrations,
        [EnumMember(Value = "ihpReferrals")]
        IhpReferrals,
        [EnumMember(Value = "ihpEligible")]
        IhpEligible,
        [EnumMember(Value = "ihpAmount")]
        IhpAmount,
        [EnumMember(Value = "haReferrals")]
        HaReferrals,
        [EnumMember(Value = "haEligible")]
        HaEligible,
        [EnumMember(Value = "haAmount")]
        HaAmount,
        [EnumMember(Value = "onaReferrals")]
        OnaReferrals,
        [EnumMember(Value = "onaEligible")]
        OnaEligible,
        [EnumMember(Value = "onaAmount")]
        OnaAmount
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1DataSetFieldsOrderbyInputItem
    {
        [EnumMember(Value = "datasetId")]
        DatasetId,
        [EnumMember(Value = "datasetId desc")]
        DatasetIdDesc,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "name desc")]
        NameDesc,
        [EnumMember(Value = "openFemaDataSet")]
        OpenFemaDataSet,
        [EnumMember(Value = "openFemaDataSet desc")]
        OpenFemaDataSetDesc,
        [EnumMember(Value = "datasetVersion")]
        DatasetVersion,
        [EnumMember(Value = "datasetVersion desc")]
        DatasetVersionDesc,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "title desc")]
        TitleDesc,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "description desc")]
        DescriptionDesc,
        [EnumMember(Value = "type")]
        Type,
        [EnumMember(Value = "type desc")]
        TypeDesc,
        [EnumMember(Value = "sortOrder")]
        SortOrder,
        [EnumMember(Value = "sortOrder desc")]
        SortOrderDesc,
        [EnumMember(Value = "isSearchable")]
        IsSearchable,
        [EnumMember(Value = "isSearchable desc")]
        IsSearchableDesc,
        [EnumMember(Value = "isNestedObject")]
        IsNestedObject,
        [EnumMember(Value = "isNestedObject desc")]
        IsNestedObjectDesc,
        [EnumMember(Value = "isNullable")]
        IsNullable,
        [EnumMember(Value = "isNullable desc")]
        IsNullableDesc,
        [EnumMember(Value = "srid")]
        Srid,
        [EnumMember(Value = "srid desc")]
        SridDesc,
        [EnumMember(Value = "primaryKey")]
        PrimaryKey,
        [EnumMember(Value = "primaryKey desc")]
        PrimaryKeyDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1DataSetFieldsSelectInputItem
    {
        [EnumMember(Value = "datasetId")]
        DatasetId,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "openFemaDataSet")]
        OpenFemaDataSet,
        [EnumMember(Value = "datasetVersion")]
        DatasetVersion,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "type")]
        Type,
        [EnumMember(Value = "sortOrder")]
        SortOrder,
        [EnumMember(Value = "isSearchable")]
        IsSearchable,
        [EnumMember(Value = "isNestedObject")]
        IsNestedObject,
        [EnumMember(Value = "isNullable")]
        IsNullable,
        [EnumMember(Value = "srid")]
        Srid,
        [EnumMember(Value = "primaryKey")]
        PrimaryKey,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "id")]
        Id
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
        public string PrimaryITInvestmentUii { get; set; }

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
        public string DepNewUrl { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("lastDataSetRefresh")]
        public string LastDataSetRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1DataSetsOrderbyInputItem
    {
        [EnumMember(Value = "identifier")]
        Identifier,
        [EnumMember(Value = "identifier desc")]
        IdentifierDesc,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "name desc")]
        NameDesc,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "title desc")]
        TitleDesc,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "description desc")]
        DescriptionDesc,
        [EnumMember(Value = "distribution")]
        Distribution,
        [EnumMember(Value = "distribution desc")]
        DistributionDesc,
        [EnumMember(Value = "webService")]
        WebService,
        [EnumMember(Value = "webService desc")]
        WebServiceDesc,
        [EnumMember(Value = "dataDictionary")]
        DataDictionary,
        [EnumMember(Value = "dataDictionary desc")]
        DataDictionaryDesc,
        [EnumMember(Value = "keyword")]
        Keyword,
        [EnumMember(Value = "keyword desc")]
        KeywordDesc,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "modified desc")]
        ModifiedDesc,
        [EnumMember(Value = "publisher")]
        Publisher,
        [EnumMember(Value = "publisher desc")]
        PublisherDesc,
        [EnumMember(Value = "contactPoint")]
        ContactPoint,
        [EnumMember(Value = "contactPoint desc")]
        ContactPointDesc,
        [EnumMember(Value = "mbox")]
        Mbox,
        [EnumMember(Value = "mbox desc")]
        MboxDesc,
        [EnumMember(Value = "accessLevel")]
        AccessLevel,
        [EnumMember(Value = "accessLevel desc")]
        AccessLevelDesc,
        [EnumMember(Value = "landingPage")]
        LandingPage,
        [EnumMember(Value = "landingPage desc")]
        LandingPageDesc,
        [EnumMember(Value = "temporal")]
        Temporal,
        [EnumMember(Value = "temporal desc")]
        TemporalDesc,
        [EnumMember(Value = "api")]
        Api,
        [EnumMember(Value = "api desc")]
        ApiDesc,
        [EnumMember(Value = "version")]
        Version,
        [EnumMember(Value = "version desc")]
        VersionDesc,
        [EnumMember(Value = "recordCount")]
        RecordCount,
        [EnumMember(Value = "recordCount desc")]
        RecordCountDesc,
        [EnumMember(Value = "bureauCode")]
        BureauCode,
        [EnumMember(Value = "bureauCode desc")]
        BureauCodeDesc,
        [EnumMember(Value = "programCode")]
        ProgramCode,
        [EnumMember(Value = "programCode desc")]
        ProgramCodeDesc,
        [EnumMember(Value = "accessLevelComment")]
        AccessLevelComment,
        [EnumMember(Value = "accessLevelComment desc")]
        AccessLevelCommentDesc,
        [EnumMember(Value = "license")]
        License,
        [EnumMember(Value = "license desc")]
        LicenseDesc,
        [EnumMember(Value = "spatial")]
        Spatial,
        [EnumMember(Value = "spatial desc")]
        SpatialDesc,
        [EnumMember(Value = "theme")]
        Theme,
        [EnumMember(Value = "theme desc")]
        ThemeDesc,
        [EnumMember(Value = "dataQuality")]
        DataQuality,
        [EnumMember(Value = "dataQuality desc")]
        DataQualityDesc,
        [EnumMember(Value = "accrualPeriodicity")]
        AccrualPeriodicity,
        [EnumMember(Value = "accrualPeriodicity desc")]
        AccrualPeriodicityDesc,
        [EnumMember(Value = "language")]
        Language,
        [EnumMember(Value = "language desc")]
        LanguageDesc,
        [EnumMember(Value = "primaryITInvestmentUII")]
        PrimaryITInvestmentUii,
        [EnumMember(Value = "primaryITInvestmentUII desc")]
        PrimaryITInvestmentUiiDesc,
        [EnumMember(Value = "references")]
        References,
        [EnumMember(Value = "references desc")]
        ReferencesDesc,
        [EnumMember(Value = "issued")]
        Issued,
        [EnumMember(Value = "issued desc")]
        IssuedDesc,
        [EnumMember(Value = "systemOfRecords")]
        SystemOfRecords,
        [EnumMember(Value = "systemOfRecords desc")]
        SystemOfRecordsDesc,
        [EnumMember(Value = "depDate")]
        DepDate,
        [EnumMember(Value = "depDate desc")]
        DepDateDesc,
        [EnumMember(Value = "depApiMessage")]
        DepApiMessage,
        [EnumMember(Value = "depApiMessage desc")]
        DepApiMessageDesc,
        [EnumMember(Value = "depWebMessage")]
        DepWebMessage,
        [EnumMember(Value = "depWebMessage desc")]
        DepWebMessageDesc,
        [EnumMember(Value = "depNewURL")]
        DepNewUrl,
        [EnumMember(Value = "depNewURL desc")]
        DepNewUrlDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "lastDataSetRefresh")]
        LastDataSetRefresh,
        [EnumMember(Value = "lastDataSetRefresh desc")]
        LastDataSetRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1DataSetsSelectInputItem
    {
        [EnumMember(Value = "identifier")]
        Identifier,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "distribution")]
        Distribution,
        [EnumMember(Value = "webService")]
        WebService,
        [EnumMember(Value = "dataDictionary")]
        DataDictionary,
        [EnumMember(Value = "keyword")]
        Keyword,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "publisher")]
        Publisher,
        [EnumMember(Value = "contactPoint")]
        ContactPoint,
        [EnumMember(Value = "mbox")]
        Mbox,
        [EnumMember(Value = "accessLevel")]
        AccessLevel,
        [EnumMember(Value = "landingPage")]
        LandingPage,
        [EnumMember(Value = "temporal")]
        Temporal,
        [EnumMember(Value = "api")]
        Api,
        [EnumMember(Value = "version")]
        Version,
        [EnumMember(Value = "recordCount")]
        RecordCount,
        [EnumMember(Value = "bureauCode")]
        BureauCode,
        [EnumMember(Value = "programCode")]
        ProgramCode,
        [EnumMember(Value = "accessLevelComment")]
        AccessLevelComment,
        [EnumMember(Value = "license")]
        License,
        [EnumMember(Value = "spatial")]
        Spatial,
        [EnumMember(Value = "theme")]
        Theme,
        [EnumMember(Value = "dataQuality")]
        DataQuality,
        [EnumMember(Value = "accrualPeriodicity")]
        AccrualPeriodicity,
        [EnumMember(Value = "language")]
        Language,
        [EnumMember(Value = "primaryITInvestmentUII")]
        PrimaryITInvestmentUii,
        [EnumMember(Value = "references")]
        References,
        [EnumMember(Value = "issued")]
        Issued,
        [EnumMember(Value = "systemOfRecords")]
        SystemOfRecords,
        [EnumMember(Value = "depDate")]
        DepDate,
        [EnumMember(Value = "depApiMessage")]
        DepApiMessage,
        [EnumMember(Value = "depWebMessage")]
        DepWebMessage,
        [EnumMember(Value = "depNewURL")]
        DepNewUrl,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastDataSetRefresh")]
        LastDataSetRefresh,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "id")]
        Id
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2FemaRegionsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "name desc")]
        NameDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "address")]
        Address,
        [EnumMember(Value = "address desc")]
        AddressDesc,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "city desc")]
        CityDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "zipCode desc")]
        ZipCodeDesc,
        [EnumMember(Value = "states")]
        States,
        [EnumMember(Value = "states desc")]
        StatesDesc,
        [EnumMember(Value = "loc")]
        Loc,
        [EnumMember(Value = "loc desc")]
        LocDesc,
        [EnumMember(Value = "regionGeometry")]
        RegionGeometry,
        [EnumMember(Value = "regionGeometry desc")]
        RegionGeometryDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2FemaRegionsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "address")]
        Address,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "states")]
        States,
        [EnumMember(Value = "loc")]
        Loc,
        [EnumMember(Value = "regionGeometry")]
        RegionGeometry,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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
        public string PostFirmConstructionIndicator { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2FimaNfipClaimsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "agricultureStructureIndicator")]
        AgricultureStructureIndicator,
        [EnumMember(Value = "agricultureStructureIndicator desc")]
        AgricultureStructureIndicatorDesc,
        [EnumMember(Value = "asOfDate")]
        AsOfDate,
        [EnumMember(Value = "asOfDate desc")]
        AsOfDateDesc,
        [EnumMember(Value = "basementEnclosureCrawlspaceType")]
        BasementEnclosureCrawlspaceType,
        [EnumMember(Value = "basementEnclosureCrawlspaceType desc")]
        BasementEnclosureCrawlspaceTypeDesc,
        [EnumMember(Value = "policyCount")]
        PolicyCount,
        [EnumMember(Value = "policyCount desc")]
        PolicyCountDesc,
        [EnumMember(Value = "crsClassificationCode")]
        CrsClassificationCode,
        [EnumMember(Value = "crsClassificationCode desc")]
        CrsClassificationCodeDesc,
        [EnumMember(Value = "dateOfLoss")]
        DateOfLoss,
        [EnumMember(Value = "dateOfLoss desc")]
        DateOfLossDesc,
        [EnumMember(Value = "elevatedBuildingIndicator")]
        ElevatedBuildingIndicator,
        [EnumMember(Value = "elevatedBuildingIndicator desc")]
        ElevatedBuildingIndicatorDesc,
        [EnumMember(Value = "elevationCertificateIndicator")]
        ElevationCertificateIndicator,
        [EnumMember(Value = "elevationCertificateIndicator desc")]
        ElevationCertificateIndicatorDesc,
        [EnumMember(Value = "elevationDifference")]
        ElevationDifference,
        [EnumMember(Value = "elevationDifference desc")]
        ElevationDifferenceDesc,
        [EnumMember(Value = "baseFloodElevation")]
        BaseFloodElevation,
        [EnumMember(Value = "baseFloodElevation desc")]
        BaseFloodElevationDesc,
        [EnumMember(Value = "ratedFloodZone")]
        RatedFloodZone,
        [EnumMember(Value = "ratedFloodZone desc")]
        RatedFloodZoneDesc,
        [EnumMember(Value = "houseWorship")]
        HouseWorship,
        [EnumMember(Value = "houseWorship desc")]
        HouseWorshipDesc,
        [EnumMember(Value = "locationOfContents")]
        LocationOfContents,
        [EnumMember(Value = "locationOfContents desc")]
        LocationOfContentsDesc,
        [EnumMember(Value = "lowestAdjacentGrade")]
        LowestAdjacentGrade,
        [EnumMember(Value = "lowestAdjacentGrade desc")]
        LowestAdjacentGradeDesc,
        [EnumMember(Value = "lowestFloorElevation")]
        LowestFloorElevation,
        [EnumMember(Value = "lowestFloorElevation desc")]
        LowestFloorElevationDesc,
        [EnumMember(Value = "numberOfFloorsInTheInsuredBuilding")]
        NumberOfFloorsInTheInsuredBuilding,
        [EnumMember(Value = "numberOfFloorsInTheInsuredBuilding desc")]
        NumberOfFloorsInTheInsuredBuildingDesc,
        [EnumMember(Value = "nonProfitIndicator")]
        NonProfitIndicator,
        [EnumMember(Value = "nonProfitIndicator desc")]
        NonProfitIndicatorDesc,
        [EnumMember(Value = "obstructionType")]
        ObstructionType,
        [EnumMember(Value = "obstructionType desc")]
        ObstructionTypeDesc,
        [EnumMember(Value = "occupancyType")]
        OccupancyType,
        [EnumMember(Value = "occupancyType desc")]
        OccupancyTypeDesc,
        [EnumMember(Value = "originalConstructionDate")]
        OriginalConstructionDate,
        [EnumMember(Value = "originalConstructionDate desc")]
        OriginalConstructionDateDesc,
        [EnumMember(Value = "originalNBDate")]
        OriginalNBDate,
        [EnumMember(Value = "originalNBDate desc")]
        OriginalNBDateDesc,
        [EnumMember(Value = "amountPaidOnBuildingClaim")]
        AmountPaidOnBuildingClaim,
        [EnumMember(Value = "amountPaidOnBuildingClaim desc")]
        AmountPaidOnBuildingClaimDesc,
        [EnumMember(Value = "amountPaidOnContentsClaim")]
        AmountPaidOnContentsClaim,
        [EnumMember(Value = "amountPaidOnContentsClaim desc")]
        AmountPaidOnContentsClaimDesc,
        [EnumMember(Value = "amountPaidOnIncreasedCostOfComplianceClaim")]
        AmountPaidOnIncreasedCostOfComplianceClaim,
        [EnumMember(Value = "amountPaidOnIncreasedCostOfComplianceClaim desc")]
        AmountPaidOnIncreasedCostOfComplianceClaimDesc,
        [EnumMember(Value = "postFIRMConstructionIndicator")]
        PostFirmConstructionIndicator,
        [EnumMember(Value = "postFIRMConstructionIndicator desc")]
        PostFirmConstructionIndicatorDesc,
        [EnumMember(Value = "rateMethod")]
        RateMethod,
        [EnumMember(Value = "rateMethod desc")]
        RateMethodDesc,
        [EnumMember(Value = "smallBusinessIndicatorBuilding")]
        SmallBusinessIndicatorBuilding,
        [EnumMember(Value = "smallBusinessIndicatorBuilding desc")]
        SmallBusinessIndicatorBuildingDesc,
        [EnumMember(Value = "totalBuildingInsuranceCoverage")]
        TotalBuildingInsuranceCoverage,
        [EnumMember(Value = "totalBuildingInsuranceCoverage desc")]
        TotalBuildingInsuranceCoverageDesc,
        [EnumMember(Value = "totalContentsInsuranceCoverage")]
        TotalContentsInsuranceCoverage,
        [EnumMember(Value = "totalContentsInsuranceCoverage desc")]
        TotalContentsInsuranceCoverageDesc,
        [EnumMember(Value = "yearOfLoss")]
        YearOfLoss,
        [EnumMember(Value = "yearOfLoss desc")]
        YearOfLossDesc,
        [EnumMember(Value = "primaryResidenceIndicator")]
        PrimaryResidenceIndicator,
        [EnumMember(Value = "primaryResidenceIndicator desc")]
        PrimaryResidenceIndicatorDesc,
        [EnumMember(Value = "buildingDamageAmount")]
        BuildingDamageAmount,
        [EnumMember(Value = "buildingDamageAmount desc")]
        BuildingDamageAmountDesc,
        [EnumMember(Value = "buildingDeductibleCode")]
        BuildingDeductibleCode,
        [EnumMember(Value = "buildingDeductibleCode desc")]
        BuildingDeductibleCodeDesc,
        [EnumMember(Value = "netBuildingPaymentAmount")]
        NetBuildingPaymentAmount,
        [EnumMember(Value = "netBuildingPaymentAmount desc")]
        NetBuildingPaymentAmountDesc,
        [EnumMember(Value = "buildingPropertyValue")]
        BuildingPropertyValue,
        [EnumMember(Value = "buildingPropertyValue desc")]
        BuildingPropertyValueDesc,
        [EnumMember(Value = "causeOfDamage")]
        CauseOfDamage,
        [EnumMember(Value = "causeOfDamage desc")]
        CauseOfDamageDesc,
        [EnumMember(Value = "condominiumCoverageTypeCode")]
        CondominiumCoverageTypeCode,
        [EnumMember(Value = "condominiumCoverageTypeCode desc")]
        CondominiumCoverageTypeCodeDesc,
        [EnumMember(Value = "contentsDamageAmount")]
        ContentsDamageAmount,
        [EnumMember(Value = "contentsDamageAmount desc")]
        ContentsDamageAmountDesc,
        [EnumMember(Value = "contentsDeductibleCode")]
        ContentsDeductibleCode,
        [EnumMember(Value = "contentsDeductibleCode desc")]
        ContentsDeductibleCodeDesc,
        [EnumMember(Value = "netContentsPaymentAmount")]
        NetContentsPaymentAmount,
        [EnumMember(Value = "netContentsPaymentAmount desc")]
        NetContentsPaymentAmountDesc,
        [EnumMember(Value = "contentsPropertyValue")]
        ContentsPropertyValue,
        [EnumMember(Value = "contentsPropertyValue desc")]
        ContentsPropertyValueDesc,
        [EnumMember(Value = "disasterAssistanceCoverageRequired")]
        DisasterAssistanceCoverageRequired,
        [EnumMember(Value = "disasterAssistanceCoverageRequired desc")]
        DisasterAssistanceCoverageRequiredDesc,
        [EnumMember(Value = "eventDesignationNumber")]
        EventDesignationNumber,
        [EnumMember(Value = "eventDesignationNumber desc")]
        EventDesignationNumberDesc,
        [EnumMember(Value = "ficoNumber")]
        FicoNumber,
        [EnumMember(Value = "ficoNumber desc")]
        FicoNumberDesc,
        [EnumMember(Value = "floodCharacteristicsIndicator")]
        FloodCharacteristicsIndicator,
        [EnumMember(Value = "floodCharacteristicsIndicator desc")]
        FloodCharacteristicsIndicatorDesc,
        [EnumMember(Value = "floodWaterDuration")]
        FloodWaterDuration,
        [EnumMember(Value = "floodWaterDuration desc")]
        FloodWaterDurationDesc,
        [EnumMember(Value = "floodproofedIndicator")]
        FloodproofedIndicator,
        [EnumMember(Value = "floodproofedIndicator desc")]
        FloodproofedIndicatorDesc,
        [EnumMember(Value = "floodEvent")]
        FloodEvent,
        [EnumMember(Value = "floodEvent desc")]
        FloodEventDesc,
        [EnumMember(Value = "iccCoverage")]
        IccCoverage,
        [EnumMember(Value = "iccCoverage desc")]
        IccCoverageDesc,
        [EnumMember(Value = "netIccPaymentAmount")]
        NetIccPaymentAmount,
        [EnumMember(Value = "netIccPaymentAmount desc")]
        NetIccPaymentAmountDesc,
        [EnumMember(Value = "nfipRatedCommunityNumber")]
        NfipRatedCommunityNumber,
        [EnumMember(Value = "nfipRatedCommunityNumber desc")]
        NfipRatedCommunityNumberDesc,
        [EnumMember(Value = "nfipCommunityNumberCurrent")]
        NfipCommunityNumberCurrent,
        [EnumMember(Value = "nfipCommunityNumberCurrent desc")]
        NfipCommunityNumberCurrentDesc,
        [EnumMember(Value = "nfipCommunityName")]
        NfipCommunityName,
        [EnumMember(Value = "nfipCommunityName desc")]
        NfipCommunityNameDesc,
        [EnumMember(Value = "nonPaymentReasonContents")]
        NonPaymentReasonContents,
        [EnumMember(Value = "nonPaymentReasonContents desc")]
        NonPaymentReasonContentsDesc,
        [EnumMember(Value = "nonPaymentReasonBuilding")]
        NonPaymentReasonBuilding,
        [EnumMember(Value = "nonPaymentReasonBuilding desc")]
        NonPaymentReasonBuildingDesc,
        [EnumMember(Value = "numberOfUnits")]
        NumberOfUnits,
        [EnumMember(Value = "numberOfUnits desc")]
        NumberOfUnitsDesc,
        [EnumMember(Value = "buildingReplacementCost")]
        BuildingReplacementCost,
        [EnumMember(Value = "buildingReplacementCost desc")]
        BuildingReplacementCostDesc,
        [EnumMember(Value = "contentsReplacementCost")]
        ContentsReplacementCost,
        [EnumMember(Value = "contentsReplacementCost desc")]
        ContentsReplacementCostDesc,
        [EnumMember(Value = "replacementCostBasis")]
        ReplacementCostBasis,
        [EnumMember(Value = "replacementCostBasis desc")]
        ReplacementCostBasisDesc,
        [EnumMember(Value = "stateOwnedIndicator")]
        StateOwnedIndicator,
        [EnumMember(Value = "stateOwnedIndicator desc")]
        StateOwnedIndicatorDesc,
        [EnumMember(Value = "waterDepth")]
        WaterDepth,
        [EnumMember(Value = "waterDepth desc")]
        WaterDepthDesc,
        [EnumMember(Value = "floodZoneCurrent")]
        FloodZoneCurrent,
        [EnumMember(Value = "floodZoneCurrent desc")]
        FloodZoneCurrentDesc,
        [EnumMember(Value = "buildingDescriptionCode")]
        BuildingDescriptionCode,
        [EnumMember(Value = "buildingDescriptionCode desc")]
        BuildingDescriptionCodeDesc,
        [EnumMember(Value = "rentalPropertyIndicator")]
        RentalPropertyIndicator,
        [EnumMember(Value = "rentalPropertyIndicator desc")]
        RentalPropertyIndicatorDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "reportedCity")]
        ReportedCity,
        [EnumMember(Value = "reportedCity desc")]
        ReportedCityDesc,
        [EnumMember(Value = "reportedZipCode")]
        ReportedZipCode,
        [EnumMember(Value = "reportedZipCode desc")]
        ReportedZipCodeDesc,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "countyCode desc")]
        CountyCodeDesc,
        [EnumMember(Value = "censusTract")]
        CensusTract,
        [EnumMember(Value = "censusTract desc")]
        CensusTractDesc,
        [EnumMember(Value = "censusBlockGroupFips")]
        CensusBlockGroupFips,
        [EnumMember(Value = "censusBlockGroupFips desc")]
        CensusBlockGroupFipsDesc,
        [EnumMember(Value = "latitude")]
        Latitude,
        [EnumMember(Value = "latitude desc")]
        LatitudeDesc,
        [EnumMember(Value = "longitude")]
        Longitude,
        [EnumMember(Value = "longitude desc")]
        LongitudeDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2FimaNfipClaimsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "agricultureStructureIndicator")]
        AgricultureStructureIndicator,
        [EnumMember(Value = "asOfDate")]
        AsOfDate,
        [EnumMember(Value = "basementEnclosureCrawlspaceType")]
        BasementEnclosureCrawlspaceType,
        [EnumMember(Value = "policyCount")]
        PolicyCount,
        [EnumMember(Value = "crsClassificationCode")]
        CrsClassificationCode,
        [EnumMember(Value = "dateOfLoss")]
        DateOfLoss,
        [EnumMember(Value = "elevatedBuildingIndicator")]
        ElevatedBuildingIndicator,
        [EnumMember(Value = "elevationCertificateIndicator")]
        ElevationCertificateIndicator,
        [EnumMember(Value = "elevationDifference")]
        ElevationDifference,
        [EnumMember(Value = "baseFloodElevation")]
        BaseFloodElevation,
        [EnumMember(Value = "ratedFloodZone")]
        RatedFloodZone,
        [EnumMember(Value = "houseWorship")]
        HouseWorship,
        [EnumMember(Value = "locationOfContents")]
        LocationOfContents,
        [EnumMember(Value = "lowestAdjacentGrade")]
        LowestAdjacentGrade,
        [EnumMember(Value = "lowestFloorElevation")]
        LowestFloorElevation,
        [EnumMember(Value = "numberOfFloorsInTheInsuredBuilding")]
        NumberOfFloorsInTheInsuredBuilding,
        [EnumMember(Value = "nonProfitIndicator")]
        NonProfitIndicator,
        [EnumMember(Value = "obstructionType")]
        ObstructionType,
        [EnumMember(Value = "occupancyType")]
        OccupancyType,
        [EnumMember(Value = "originalConstructionDate")]
        OriginalConstructionDate,
        [EnumMember(Value = "originalNBDate")]
        OriginalNBDate,
        [EnumMember(Value = "amountPaidOnBuildingClaim")]
        AmountPaidOnBuildingClaim,
        [EnumMember(Value = "amountPaidOnContentsClaim")]
        AmountPaidOnContentsClaim,
        [EnumMember(Value = "amountPaidOnIncreasedCostOfComplianceClaim")]
        AmountPaidOnIncreasedCostOfComplianceClaim,
        [EnumMember(Value = "postFIRMConstructionIndicator")]
        PostFirmConstructionIndicator,
        [EnumMember(Value = "rateMethod")]
        RateMethod,
        [EnumMember(Value = "smallBusinessIndicatorBuilding")]
        SmallBusinessIndicatorBuilding,
        [EnumMember(Value = "totalBuildingInsuranceCoverage")]
        TotalBuildingInsuranceCoverage,
        [EnumMember(Value = "totalContentsInsuranceCoverage")]
        TotalContentsInsuranceCoverage,
        [EnumMember(Value = "yearOfLoss")]
        YearOfLoss,
        [EnumMember(Value = "primaryResidenceIndicator")]
        PrimaryResidenceIndicator,
        [EnumMember(Value = "buildingDamageAmount")]
        BuildingDamageAmount,
        [EnumMember(Value = "buildingDeductibleCode")]
        BuildingDeductibleCode,
        [EnumMember(Value = "netBuildingPaymentAmount")]
        NetBuildingPaymentAmount,
        [EnumMember(Value = "buildingPropertyValue")]
        BuildingPropertyValue,
        [EnumMember(Value = "causeOfDamage")]
        CauseOfDamage,
        [EnumMember(Value = "condominiumCoverageTypeCode")]
        CondominiumCoverageTypeCode,
        [EnumMember(Value = "contentsDamageAmount")]
        ContentsDamageAmount,
        [EnumMember(Value = "contentsDeductibleCode")]
        ContentsDeductibleCode,
        [EnumMember(Value = "netContentsPaymentAmount")]
        NetContentsPaymentAmount,
        [EnumMember(Value = "contentsPropertyValue")]
        ContentsPropertyValue,
        [EnumMember(Value = "disasterAssistanceCoverageRequired")]
        DisasterAssistanceCoverageRequired,
        [EnumMember(Value = "eventDesignationNumber")]
        EventDesignationNumber,
        [EnumMember(Value = "ficoNumber")]
        FicoNumber,
        [EnumMember(Value = "floodCharacteristicsIndicator")]
        FloodCharacteristicsIndicator,
        [EnumMember(Value = "floodWaterDuration")]
        FloodWaterDuration,
        [EnumMember(Value = "floodproofedIndicator")]
        FloodproofedIndicator,
        [EnumMember(Value = "floodEvent")]
        FloodEvent,
        [EnumMember(Value = "iccCoverage")]
        IccCoverage,
        [EnumMember(Value = "netIccPaymentAmount")]
        NetIccPaymentAmount,
        [EnumMember(Value = "nfipRatedCommunityNumber")]
        NfipRatedCommunityNumber,
        [EnumMember(Value = "nfipCommunityNumberCurrent")]
        NfipCommunityNumberCurrent,
        [EnumMember(Value = "nfipCommunityName")]
        NfipCommunityName,
        [EnumMember(Value = "nonPaymentReasonContents")]
        NonPaymentReasonContents,
        [EnumMember(Value = "nonPaymentReasonBuilding")]
        NonPaymentReasonBuilding,
        [EnumMember(Value = "numberOfUnits")]
        NumberOfUnits,
        [EnumMember(Value = "buildingReplacementCost")]
        BuildingReplacementCost,
        [EnumMember(Value = "contentsReplacementCost")]
        ContentsReplacementCost,
        [EnumMember(Value = "replacementCostBasis")]
        ReplacementCostBasis,
        [EnumMember(Value = "stateOwnedIndicator")]
        StateOwnedIndicator,
        [EnumMember(Value = "waterDepth")]
        WaterDepth,
        [EnumMember(Value = "floodZoneCurrent")]
        FloodZoneCurrent,
        [EnumMember(Value = "buildingDescriptionCode")]
        BuildingDescriptionCode,
        [EnumMember(Value = "rentalPropertyIndicator")]
        RentalPropertyIndicator,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "reportedCity")]
        ReportedCity,
        [EnumMember(Value = "reportedZipCode")]
        ReportedZipCode,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "censusTract")]
        CensusTract,
        [EnumMember(Value = "censusBlockGroupFips")]
        CensusBlockGroupFips,
        [EnumMember(Value = "latitude")]
        Latitude,
        [EnumMember(Value = "longitude")]
        Longitude
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
        public string PostFirmConstructionIndicator { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2FimaNfipPoliciesOrderbyInputItem
    {
        [EnumMember(Value = "agricultureStructureIndicator")]
        AgricultureStructureIndicator,
        [EnumMember(Value = "agricultureStructureIndicator desc")]
        AgricultureStructureIndicatorDesc,
        [EnumMember(Value = "baseFloodElevation")]
        BaseFloodElevation,
        [EnumMember(Value = "baseFloodElevation desc")]
        BaseFloodElevationDesc,
        [EnumMember(Value = "basementEnclosureCrawlspaceType")]
        BasementEnclosureCrawlspaceType,
        [EnumMember(Value = "basementEnclosureCrawlspaceType desc")]
        BasementEnclosureCrawlspaceTypeDesc,
        [EnumMember(Value = "cancellationDateOfFloodPolicy")]
        CancellationDateOfFloodPolicy,
        [EnumMember(Value = "cancellationDateOfFloodPolicy desc")]
        CancellationDateOfFloodPolicyDesc,
        [EnumMember(Value = "condominiumCoverageTypeCode")]
        CondominiumCoverageTypeCode,
        [EnumMember(Value = "condominiumCoverageTypeCode desc")]
        CondominiumCoverageTypeCodeDesc,
        [EnumMember(Value = "construction")]
        Construction,
        [EnumMember(Value = "construction desc")]
        ConstructionDesc,
        [EnumMember(Value = "crsClassCode")]
        CrsClassCode,
        [EnumMember(Value = "crsClassCode desc")]
        CrsClassCodeDesc,
        [EnumMember(Value = "buildingDeductibleCode")]
        BuildingDeductibleCode,
        [EnumMember(Value = "buildingDeductibleCode desc")]
        BuildingDeductibleCodeDesc,
        [EnumMember(Value = "contentsDeductibleCode")]
        ContentsDeductibleCode,
        [EnumMember(Value = "contentsDeductibleCode desc")]
        ContentsDeductibleCodeDesc,
        [EnumMember(Value = "elevatedBuildingIndicator")]
        ElevatedBuildingIndicator,
        [EnumMember(Value = "elevatedBuildingIndicator desc")]
        ElevatedBuildingIndicatorDesc,
        [EnumMember(Value = "elevationCertificateIndicator")]
        ElevationCertificateIndicator,
        [EnumMember(Value = "elevationCertificateIndicator desc")]
        ElevationCertificateIndicatorDesc,
        [EnumMember(Value = "elevationDifference")]
        ElevationDifference,
        [EnumMember(Value = "elevationDifference desc")]
        ElevationDifferenceDesc,
        [EnumMember(Value = "federalPolicyFee")]
        FederalPolicyFee,
        [EnumMember(Value = "federalPolicyFee desc")]
        FederalPolicyFeeDesc,
        [EnumMember(Value = "ratedFloodZone")]
        RatedFloodZone,
        [EnumMember(Value = "ratedFloodZone desc")]
        RatedFloodZoneDesc,
        [EnumMember(Value = "hfiaaSurcharge")]
        HfiaaSurcharge,
        [EnumMember(Value = "hfiaaSurcharge desc")]
        HfiaaSurchargeDesc,
        [EnumMember(Value = "houseOfWorshipIndicator")]
        HouseOfWorshipIndicator,
        [EnumMember(Value = "houseOfWorshipIndicator desc")]
        HouseOfWorshipIndicatorDesc,
        [EnumMember(Value = "locationOfContents")]
        LocationOfContents,
        [EnumMember(Value = "locationOfContents desc")]
        LocationOfContentsDesc,
        [EnumMember(Value = "lowestAdjacentGrade")]
        LowestAdjacentGrade,
        [EnumMember(Value = "lowestAdjacentGrade desc")]
        LowestAdjacentGradeDesc,
        [EnumMember(Value = "lowestFloorElevation")]
        LowestFloorElevation,
        [EnumMember(Value = "lowestFloorElevation desc")]
        LowestFloorElevationDesc,
        [EnumMember(Value = "nonProfitIndicator")]
        NonProfitIndicator,
        [EnumMember(Value = "nonProfitIndicator desc")]
        NonProfitIndicatorDesc,
        [EnumMember(Value = "numberOfFloorsInInsuredBuilding")]
        NumberOfFloorsInInsuredBuilding,
        [EnumMember(Value = "numberOfFloorsInInsuredBuilding desc")]
        NumberOfFloorsInInsuredBuildingDesc,
        [EnumMember(Value = "obstructionType")]
        ObstructionType,
        [EnumMember(Value = "obstructionType desc")]
        ObstructionTypeDesc,
        [EnumMember(Value = "occupancyType")]
        OccupancyType,
        [EnumMember(Value = "occupancyType desc")]
        OccupancyTypeDesc,
        [EnumMember(Value = "originalConstructionDate")]
        OriginalConstructionDate,
        [EnumMember(Value = "originalConstructionDate desc")]
        OriginalConstructionDateDesc,
        [EnumMember(Value = "originalNBDate")]
        OriginalNBDate,
        [EnumMember(Value = "originalNBDate desc")]
        OriginalNBDateDesc,
        [EnumMember(Value = "policyCost")]
        PolicyCost,
        [EnumMember(Value = "policyCost desc")]
        PolicyCostDesc,
        [EnumMember(Value = "policyCount")]
        PolicyCount,
        [EnumMember(Value = "policyCount desc")]
        PolicyCountDesc,
        [EnumMember(Value = "policyEffectiveDate")]
        PolicyEffectiveDate,
        [EnumMember(Value = "policyEffectiveDate desc")]
        PolicyEffectiveDateDesc,
        [EnumMember(Value = "policyTerminationDate")]
        PolicyTerminationDate,
        [EnumMember(Value = "policyTerminationDate desc")]
        PolicyTerminationDateDesc,
        [EnumMember(Value = "policyTermIndicator")]
        PolicyTermIndicator,
        [EnumMember(Value = "policyTermIndicator desc")]
        PolicyTermIndicatorDesc,
        [EnumMember(Value = "postFIRMConstructionIndicator")]
        PostFirmConstructionIndicator,
        [EnumMember(Value = "postFIRMConstructionIndicator desc")]
        PostFirmConstructionIndicatorDesc,
        [EnumMember(Value = "primaryResidenceIndicator")]
        PrimaryResidenceIndicator,
        [EnumMember(Value = "primaryResidenceIndicator desc")]
        PrimaryResidenceIndicatorDesc,
        [EnumMember(Value = "rateMethod")]
        RateMethod,
        [EnumMember(Value = "rateMethod desc")]
        RateMethodDesc,
        [EnumMember(Value = "regularEmergencyProgramIndicator")]
        RegularEmergencyProgramIndicator,
        [EnumMember(Value = "regularEmergencyProgramIndicator desc")]
        RegularEmergencyProgramIndicatorDesc,
        [EnumMember(Value = "smallBusinessIndicatorBuilding")]
        SmallBusinessIndicatorBuilding,
        [EnumMember(Value = "smallBusinessIndicatorBuilding desc")]
        SmallBusinessIndicatorBuildingDesc,
        [EnumMember(Value = "totalBuildingInsuranceCoverage")]
        TotalBuildingInsuranceCoverage,
        [EnumMember(Value = "totalBuildingInsuranceCoverage desc")]
        TotalBuildingInsuranceCoverageDesc,
        [EnumMember(Value = "totalContentsInsuranceCoverage")]
        TotalContentsInsuranceCoverage,
        [EnumMember(Value = "totalContentsInsuranceCoverage desc")]
        TotalContentsInsuranceCoverageDesc,
        [EnumMember(Value = "totalInsurancePremiumOfThePolicy")]
        TotalInsurancePremiumOfThePolicy,
        [EnumMember(Value = "totalInsurancePremiumOfThePolicy desc")]
        TotalInsurancePremiumOfThePolicyDesc,
        [EnumMember(Value = "cancellationVoidanceReasonCode")]
        CancellationVoidanceReasonCode,
        [EnumMember(Value = "cancellationVoidanceReasonCode desc")]
        CancellationVoidanceReasonCodeDesc,
        [EnumMember(Value = "subsidizedRateType")]
        SubsidizedRateType,
        [EnumMember(Value = "subsidizedRateType desc")]
        SubsidizedRateTypeDesc,
        [EnumMember(Value = "iccPremium")]
        IccPremium,
        [EnumMember(Value = "iccPremium desc")]
        IccPremiumDesc,
        [EnumMember(Value = "reserveFundAssessment")]
        ReserveFundAssessment,
        [EnumMember(Value = "reserveFundAssessment desc")]
        ReserveFundAssessmentDesc,
        [EnumMember(Value = "communityProbationSurcharge")]
        CommunityProbationSurcharge,
        [EnumMember(Value = "communityProbationSurcharge desc")]
        CommunityProbationSurchargeDesc,
        [EnumMember(Value = "premiumPaymentIndicator")]
        PremiumPaymentIndicator,
        [EnumMember(Value = "premiumPaymentIndicator desc")]
        PremiumPaymentIndicatorDesc,
        [EnumMember(Value = "buildingReplacementCost")]
        BuildingReplacementCost,
        [EnumMember(Value = "buildingReplacementCost desc")]
        BuildingReplacementCostDesc,
        [EnumMember(Value = "basicBuildingRate")]
        BasicBuildingRate,
        [EnumMember(Value = "basicBuildingRate desc")]
        BasicBuildingRateDesc,
        [EnumMember(Value = "additionalBuildingRate")]
        AdditionalBuildingRate,
        [EnumMember(Value = "additionalBuildingRate desc")]
        AdditionalBuildingRateDesc,
        [EnumMember(Value = "basicContentsRate")]
        BasicContentsRate,
        [EnumMember(Value = "basicContentsRate desc")]
        BasicContentsRateDesc,
        AdditionalContentsRate,
        [EnumMember(Value = "AdditionalContentsRate desc")]
        AdditionalContentsRateDesc,
        [EnumMember(Value = "enclosureTypeCode")]
        EnclosureTypeCode,
        [EnumMember(Value = "enclosureTypeCode desc")]
        EnclosureTypeCodeDesc,
        [EnumMember(Value = "buildingDescriptionCode")]
        BuildingDescriptionCode,
        [EnumMember(Value = "buildingDescriptionCode desc")]
        BuildingDescriptionCodeDesc,
        [EnumMember(Value = "insuranceToValueCode")]
        InsuranceToValueCode,
        [EnumMember(Value = "insuranceToValueCode desc")]
        InsuranceToValueCodeDesc,
        [EnumMember(Value = "postFirmVzoneIndicator")]
        PostFirmVzoneIndicator,
        [EnumMember(Value = "postFirmVzoneIndicator desc")]
        PostFirmVzoneIndicatorDesc,
        [EnumMember(Value = "floodproofedIndicator")]
        FloodproofedIndicator,
        [EnumMember(Value = "floodproofedIndicator desc")]
        FloodproofedIndicatorDesc,
        [EnumMember(Value = "waitingPeriodType")]
        WaitingPeriodType,
        [EnumMember(Value = "waitingPeriodType desc")]
        WaitingPeriodTypeDesc,
        [EnumMember(Value = "rolloverTransferCode")]
        RolloverTransferCode,
        [EnumMember(Value = "rolloverTransferCode desc")]
        RolloverTransferCodeDesc,
        [EnumMember(Value = "endorsementEffectiveDate")]
        EndorsementEffectiveDate,
        [EnumMember(Value = "endorsementEffectiveDate desc")]
        EndorsementEffectiveDateDesc,
        [EnumMember(Value = "propertyPurchaseDate")]
        PropertyPurchaseDate,
        [EnumMember(Value = "propertyPurchaseDate desc")]
        PropertyPurchaseDateDesc,
        [EnumMember(Value = "rentalPropertyIndicator")]
        RentalPropertyIndicator,
        [EnumMember(Value = "rentalPropertyIndicator desc")]
        RentalPropertyIndicatorDesc,
        [EnumMember(Value = "tenantIndicator")]
        TenantIndicator,
        [EnumMember(Value = "tenantIndicator desc")]
        TenantIndicatorDesc,
        [EnumMember(Value = "stateOwnedIndicator")]
        StateOwnedIndicator,
        [EnumMember(Value = "stateOwnedIndicator desc")]
        StateOwnedIndicatorDesc,
        [EnumMember(Value = "disasterAssistanceCoverageRequiredCode")]
        DisasterAssistanceCoverageRequiredCode,
        [EnumMember(Value = "disasterAssistanceCoverageRequiredCode desc")]
        DisasterAssistanceCoverageRequiredCodeDesc,
        [EnumMember(Value = "mandatoryPurchaseFlag")]
        MandatoryPurchaseFlag,
        [EnumMember(Value = "mandatoryPurchaseFlag desc")]
        MandatoryPurchaseFlagDesc,
        [EnumMember(Value = "grandfatheringTypeCode")]
        GrandfatheringTypeCode,
        [EnumMember(Value = "grandfatheringTypeCode desc")]
        GrandfatheringTypeCodeDesc,
        [EnumMember(Value = "nfipRatedCommunityNumber")]
        NfipRatedCommunityNumber,
        [EnumMember(Value = "nfipRatedCommunityNumber desc")]
        NfipRatedCommunityNumberDesc,
        [EnumMember(Value = "nfipCommunityNumberCurrent")]
        NfipCommunityNumberCurrent,
        [EnumMember(Value = "nfipCommunityNumberCurrent desc")]
        NfipCommunityNumberCurrentDesc,
        [EnumMember(Value = "nfipCommunityName")]
        NfipCommunityName,
        [EnumMember(Value = "nfipCommunityName desc")]
        NfipCommunityNameDesc,
        [EnumMember(Value = "programTypeIndicator")]
        ProgramTypeIndicator,
        [EnumMember(Value = "programTypeIndicator desc")]
        ProgramTypeIndicatorDesc,
        [EnumMember(Value = "mapPanelNumber")]
        MapPanelNumber,
        [EnumMember(Value = "mapPanelNumber desc")]
        MapPanelNumberDesc,
        [EnumMember(Value = "mapPanelSuffix")]
        MapPanelSuffix,
        [EnumMember(Value = "mapPanelSuffix desc")]
        MapPanelSuffixDesc,
        [EnumMember(Value = "floodZoneCurrent")]
        FloodZoneCurrent,
        [EnumMember(Value = "floodZoneCurrent desc")]
        FloodZoneCurrentDesc,
        [EnumMember(Value = "femaRegion")]
        FemaRegion,
        [EnumMember(Value = "femaRegion desc")]
        FemaRegionDesc,
        [EnumMember(Value = "propertyState")]
        PropertyState,
        [EnumMember(Value = "propertyState desc")]
        PropertyStateDesc,
        [EnumMember(Value = "reportedCity")]
        ReportedCity,
        [EnumMember(Value = "reportedCity desc")]
        ReportedCityDesc,
        [EnumMember(Value = "reportedZipCode")]
        ReportedZipCode,
        [EnumMember(Value = "reportedZipCode desc")]
        ReportedZipCodeDesc,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "countyCode desc")]
        CountyCodeDesc,
        [EnumMember(Value = "censusTract")]
        CensusTract,
        [EnumMember(Value = "censusTract desc")]
        CensusTractDesc,
        [EnumMember(Value = "censusBlockGroupFips")]
        CensusBlockGroupFips,
        [EnumMember(Value = "censusBlockGroupFips desc")]
        CensusBlockGroupFipsDesc,
        [EnumMember(Value = "latitude")]
        Latitude,
        [EnumMember(Value = "latitude desc")]
        LatitudeDesc,
        [EnumMember(Value = "longitude")]
        Longitude,
        [EnumMember(Value = "longitude desc")]
        LongitudeDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2FimaNfipPoliciesSelectInputItem
    {
        [EnumMember(Value = "agricultureStructureIndicator")]
        AgricultureStructureIndicator,
        [EnumMember(Value = "baseFloodElevation")]
        BaseFloodElevation,
        [EnumMember(Value = "basementEnclosureCrawlspaceType")]
        BasementEnclosureCrawlspaceType,
        [EnumMember(Value = "cancellationDateOfFloodPolicy")]
        CancellationDateOfFloodPolicy,
        [EnumMember(Value = "condominiumCoverageTypeCode")]
        CondominiumCoverageTypeCode,
        [EnumMember(Value = "construction")]
        Construction,
        [EnumMember(Value = "crsClassCode")]
        CrsClassCode,
        [EnumMember(Value = "buildingDeductibleCode")]
        BuildingDeductibleCode,
        [EnumMember(Value = "contentsDeductibleCode")]
        ContentsDeductibleCode,
        [EnumMember(Value = "elevatedBuildingIndicator")]
        ElevatedBuildingIndicator,
        [EnumMember(Value = "elevationCertificateIndicator")]
        ElevationCertificateIndicator,
        [EnumMember(Value = "elevationDifference")]
        ElevationDifference,
        [EnumMember(Value = "federalPolicyFee")]
        FederalPolicyFee,
        [EnumMember(Value = "ratedFloodZone")]
        RatedFloodZone,
        [EnumMember(Value = "hfiaaSurcharge")]
        HfiaaSurcharge,
        [EnumMember(Value = "houseOfWorshipIndicator")]
        HouseOfWorshipIndicator,
        [EnumMember(Value = "locationOfContents")]
        LocationOfContents,
        [EnumMember(Value = "lowestAdjacentGrade")]
        LowestAdjacentGrade,
        [EnumMember(Value = "lowestFloorElevation")]
        LowestFloorElevation,
        [EnumMember(Value = "nonProfitIndicator")]
        NonProfitIndicator,
        [EnumMember(Value = "numberOfFloorsInInsuredBuilding")]
        NumberOfFloorsInInsuredBuilding,
        [EnumMember(Value = "obstructionType")]
        ObstructionType,
        [EnumMember(Value = "occupancyType")]
        OccupancyType,
        [EnumMember(Value = "originalConstructionDate")]
        OriginalConstructionDate,
        [EnumMember(Value = "originalNBDate")]
        OriginalNBDate,
        [EnumMember(Value = "policyCost")]
        PolicyCost,
        [EnumMember(Value = "policyCount")]
        PolicyCount,
        [EnumMember(Value = "policyEffectiveDate")]
        PolicyEffectiveDate,
        [EnumMember(Value = "policyTerminationDate")]
        PolicyTerminationDate,
        [EnumMember(Value = "policyTermIndicator")]
        PolicyTermIndicator,
        [EnumMember(Value = "postFIRMConstructionIndicator")]
        PostFirmConstructionIndicator,
        [EnumMember(Value = "primaryResidenceIndicator")]
        PrimaryResidenceIndicator,
        [EnumMember(Value = "rateMethod")]
        RateMethod,
        [EnumMember(Value = "regularEmergencyProgramIndicator")]
        RegularEmergencyProgramIndicator,
        [EnumMember(Value = "smallBusinessIndicatorBuilding")]
        SmallBusinessIndicatorBuilding,
        [EnumMember(Value = "totalBuildingInsuranceCoverage")]
        TotalBuildingInsuranceCoverage,
        [EnumMember(Value = "totalContentsInsuranceCoverage")]
        TotalContentsInsuranceCoverage,
        [EnumMember(Value = "totalInsurancePremiumOfThePolicy")]
        TotalInsurancePremiumOfThePolicy,
        [EnumMember(Value = "cancellationVoidanceReasonCode")]
        CancellationVoidanceReasonCode,
        [EnumMember(Value = "subsidizedRateType")]
        SubsidizedRateType,
        [EnumMember(Value = "iccPremium")]
        IccPremium,
        [EnumMember(Value = "reserveFundAssessment")]
        ReserveFundAssessment,
        [EnumMember(Value = "communityProbationSurcharge")]
        CommunityProbationSurcharge,
        [EnumMember(Value = "premiumPaymentIndicator")]
        PremiumPaymentIndicator,
        [EnumMember(Value = "buildingReplacementCost")]
        BuildingReplacementCost,
        [EnumMember(Value = "basicBuildingRate")]
        BasicBuildingRate,
        [EnumMember(Value = "additionalBuildingRate")]
        AdditionalBuildingRate,
        [EnumMember(Value = "basicContentsRate")]
        BasicContentsRate,
        AdditionalContentsRate,
        [EnumMember(Value = "enclosureTypeCode")]
        EnclosureTypeCode,
        [EnumMember(Value = "buildingDescriptionCode")]
        BuildingDescriptionCode,
        [EnumMember(Value = "insuranceToValueCode")]
        InsuranceToValueCode,
        [EnumMember(Value = "postFirmVzoneIndicator")]
        PostFirmVzoneIndicator,
        [EnumMember(Value = "floodproofedIndicator")]
        FloodproofedIndicator,
        [EnumMember(Value = "waitingPeriodType")]
        WaitingPeriodType,
        [EnumMember(Value = "rolloverTransferCode")]
        RolloverTransferCode,
        [EnumMember(Value = "endorsementEffectiveDate")]
        EndorsementEffectiveDate,
        [EnumMember(Value = "propertyPurchaseDate")]
        PropertyPurchaseDate,
        [EnumMember(Value = "rentalPropertyIndicator")]
        RentalPropertyIndicator,
        [EnumMember(Value = "tenantIndicator")]
        TenantIndicator,
        [EnumMember(Value = "stateOwnedIndicator")]
        StateOwnedIndicator,
        [EnumMember(Value = "disasterAssistanceCoverageRequiredCode")]
        DisasterAssistanceCoverageRequiredCode,
        [EnumMember(Value = "mandatoryPurchaseFlag")]
        MandatoryPurchaseFlag,
        [EnumMember(Value = "grandfatheringTypeCode")]
        GrandfatheringTypeCode,
        [EnumMember(Value = "nfipRatedCommunityNumber")]
        NfipRatedCommunityNumber,
        [EnumMember(Value = "nfipCommunityNumberCurrent")]
        NfipCommunityNumberCurrent,
        [EnumMember(Value = "nfipCommunityName")]
        NfipCommunityName,
        [EnumMember(Value = "programTypeIndicator")]
        ProgramTypeIndicator,
        [EnumMember(Value = "mapPanelNumber")]
        MapPanelNumber,
        [EnumMember(Value = "mapPanelSuffix")]
        MapPanelSuffix,
        [EnumMember(Value = "floodZoneCurrent")]
        FloodZoneCurrent,
        [EnumMember(Value = "femaRegion")]
        FemaRegion,
        [EnumMember(Value = "propertyState")]
        PropertyState,
        [EnumMember(Value = "reportedCity")]
        ReportedCity,
        [EnumMember(Value = "reportedZipCode")]
        ReportedZipCode,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "censusTract")]
        CensusTract,
        [EnumMember(Value = "censusBlockGroupFips")]
        CensusBlockGroupFips,
        [EnumMember(Value = "latitude")]
        Latitude,
        [EnumMember(Value = "longitude")]
        Longitude,
        [EnumMember(Value = "id")]
        Id
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipCommunityLayerComprehensiveOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "communityIdNumber desc")]
        CommunityIdNumberDesc,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateCode desc")]
        StateCodeDesc,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "countyCode desc")]
        CountyCodeDesc,
        [EnumMember(Value = "censusGeoid")]
        CensusGeoid,
        [EnumMember(Value = "censusGeoid desc")]
        CensusGeoidDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityName desc")]
        CommunityNameDesc,
        [EnumMember(Value = "communityNameShort")]
        CommunityNameShort,
        [EnumMember(Value = "communityNameShort desc")]
        CommunityNameShortDesc,
        [EnumMember(Value = "censusYear")]
        CensusYear,
        [EnumMember(Value = "censusYear desc")]
        CensusYearDesc,
        [EnumMember(Value = "censusPopulationEntire")]
        CensusPopulationEntire,
        [EnumMember(Value = "censusPopulationEntire desc")]
        CensusPopulationEntireDesc,
        [EnumMember(Value = "censusHousingUnitsEntire")]
        CensusHousingUnitsEntire,
        [EnumMember(Value = "censusHousingUnitsEntire desc")]
        CensusHousingUnitsEntireDesc,
        [EnumMember(Value = "landAreaEntire")]
        LandAreaEntire,
        [EnumMember(Value = "landAreaEntire desc")]
        LandAreaEntireDesc,
        [EnumMember(Value = "cisType")]
        CisType,
        [EnumMember(Value = "cisType desc")]
        CisTypeDesc,
        [EnumMember(Value = "cisSource")]
        CisSource,
        [EnumMember(Value = "cisSource desc")]
        CisSourceDesc,
        [EnumMember(Value = "geometrySource")]
        GeometrySource,
        [EnumMember(Value = "geometrySource desc")]
        GeometrySourceDesc,
        [EnumMember(Value = "alternateGeoid")]
        AlternateGeoid,
        [EnumMember(Value = "alternateGeoid desc")]
        AlternateGeoidDesc,
        [EnumMember(Value = "alternateName")]
        AlternateName,
        [EnumMember(Value = "alternateName desc")]
        AlternateNameDesc,
        [EnumMember(Value = "alternateLongName")]
        AlternateLongName,
        [EnumMember(Value = "alternateLongName desc")]
        AlternateLongNameDesc,
        [EnumMember(Value = "layerCreationNotes")]
        LayerCreationNotes,
        [EnumMember(Value = "layerCreationNotes desc")]
        LayerCreationNotesDesc,
        [EnumMember(Value = "censusClassCodes")]
        CensusClassCodes,
        [EnumMember(Value = "censusClassCodes desc")]
        CensusClassCodesDesc,
        [EnumMember(Value = "censusFunctionalStatusCodes")]
        CensusFunctionalStatusCodes,
        [EnumMember(Value = "censusFunctionalStatusCodes desc")]
        CensusFunctionalStatusCodesDesc,
        [EnumMember(Value = "layerTypeCode")]
        LayerTypeCode,
        [EnumMember(Value = "layerTypeCode desc")]
        LayerTypeCodeDesc,
        [EnumMember(Value = "layerGeometry")]
        LayerGeometry,
        [EnumMember(Value = "layerGeometry desc")]
        LayerGeometryDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipCommunityLayerComprehensiveSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "censusGeoid")]
        CensusGeoid,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityNameShort")]
        CommunityNameShort,
        [EnumMember(Value = "censusYear")]
        CensusYear,
        [EnumMember(Value = "censusPopulationEntire")]
        CensusPopulationEntire,
        [EnumMember(Value = "censusHousingUnitsEntire")]
        CensusHousingUnitsEntire,
        [EnumMember(Value = "landAreaEntire")]
        LandAreaEntire,
        [EnumMember(Value = "cisType")]
        CisType,
        [EnumMember(Value = "cisSource")]
        CisSource,
        [EnumMember(Value = "geometrySource")]
        GeometrySource,
        [EnumMember(Value = "alternateGeoid")]
        AlternateGeoid,
        [EnumMember(Value = "alternateName")]
        AlternateName,
        [EnumMember(Value = "alternateLongName")]
        AlternateLongName,
        [EnumMember(Value = "layerCreationNotes")]
        LayerCreationNotes,
        [EnumMember(Value = "censusClassCodes")]
        CensusClassCodes,
        [EnumMember(Value = "censusFunctionalStatusCodes")]
        CensusFunctionalStatusCodes,
        [EnumMember(Value = "layerTypeCode")]
        LayerTypeCode,
        [EnumMember(Value = "layerGeometry")]
        LayerGeometry
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipCommunityLayerNoOverlapsSplitOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "communityIdNumber desc")]
        CommunityIdNumberDesc,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateCode desc")]
        StateCodeDesc,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "countyCode desc")]
        CountyCodeDesc,
        [EnumMember(Value = "censusGeoid")]
        CensusGeoid,
        [EnumMember(Value = "censusGeoid desc")]
        CensusGeoidDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityName desc")]
        CommunityNameDesc,
        [EnumMember(Value = "communityNameShort")]
        CommunityNameShort,
        [EnumMember(Value = "communityNameShort desc")]
        CommunityNameShortDesc,
        [EnumMember(Value = "censusYear")]
        CensusYear,
        [EnumMember(Value = "censusYear desc")]
        CensusYearDesc,
        [EnumMember(Value = "censusPopulationEntire")]
        CensusPopulationEntire,
        [EnumMember(Value = "censusPopulationEntire desc")]
        CensusPopulationEntireDesc,
        [EnumMember(Value = "censusHousingUnitsEntire")]
        CensusHousingUnitsEntire,
        [EnumMember(Value = "censusHousingUnitsEntire desc")]
        CensusHousingUnitsEntireDesc,
        [EnumMember(Value = "landAreaEntire")]
        LandAreaEntire,
        [EnumMember(Value = "landAreaEntire desc")]
        LandAreaEntireDesc,
        [EnumMember(Value = "censusPopulationPunched")]
        CensusPopulationPunched,
        [EnumMember(Value = "censusPopulationPunched desc")]
        CensusPopulationPunchedDesc,
        [EnumMember(Value = "censusHousingUnitsPunched")]
        CensusHousingUnitsPunched,
        [EnumMember(Value = "censusHousingUnitsPunched desc")]
        CensusHousingUnitsPunchedDesc,
        [EnumMember(Value = "landArea2D")]
        LandArea2D,
        [EnumMember(Value = "landArea2D desc")]
        LandArea2DDesc,
        [EnumMember(Value = "cisType")]
        CisType,
        [EnumMember(Value = "cisType desc")]
        CisTypeDesc,
        [EnumMember(Value = "cisSource")]
        CisSource,
        [EnumMember(Value = "cisSource desc")]
        CisSourceDesc,
        [EnumMember(Value = "geometrySource")]
        GeometrySource,
        [EnumMember(Value = "geometrySource desc")]
        GeometrySourceDesc,
        [EnumMember(Value = "alternateGeoid")]
        AlternateGeoid,
        [EnumMember(Value = "alternateGeoid desc")]
        AlternateGeoidDesc,
        [EnumMember(Value = "alternateName")]
        AlternateName,
        [EnumMember(Value = "alternateName desc")]
        AlternateNameDesc,
        [EnumMember(Value = "alternateLongName")]
        AlternateLongName,
        [EnumMember(Value = "alternateLongName desc")]
        AlternateLongNameDesc,
        [EnumMember(Value = "layerCreationNotes")]
        LayerCreationNotes,
        [EnumMember(Value = "layerCreationNotes desc")]
        LayerCreationNotesDesc,
        [EnumMember(Value = "censusClassCodes")]
        CensusClassCodes,
        [EnumMember(Value = "censusClassCodes desc")]
        CensusClassCodesDesc,
        [EnumMember(Value = "censusFunctionalStatusCodes")]
        CensusFunctionalStatusCodes,
        [EnumMember(Value = "censusFunctionalStatusCodes desc")]
        CensusFunctionalStatusCodesDesc,
        [EnumMember(Value = "layerTypeCode")]
        LayerTypeCode,
        [EnumMember(Value = "layerTypeCode desc")]
        LayerTypeCodeDesc,
        [EnumMember(Value = "layerGeometry")]
        LayerGeometry,
        [EnumMember(Value = "layerGeometry desc")]
        LayerGeometryDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipCommunityLayerNoOverlapsSplitSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "censusGeoid")]
        CensusGeoid,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityNameShort")]
        CommunityNameShort,
        [EnumMember(Value = "censusYear")]
        CensusYear,
        [EnumMember(Value = "censusPopulationEntire")]
        CensusPopulationEntire,
        [EnumMember(Value = "censusHousingUnitsEntire")]
        CensusHousingUnitsEntire,
        [EnumMember(Value = "landAreaEntire")]
        LandAreaEntire,
        [EnumMember(Value = "censusPopulationPunched")]
        CensusPopulationPunched,
        [EnumMember(Value = "censusHousingUnitsPunched")]
        CensusHousingUnitsPunched,
        [EnumMember(Value = "landArea2D")]
        LandArea2D,
        [EnumMember(Value = "cisType")]
        CisType,
        [EnumMember(Value = "cisSource")]
        CisSource,
        [EnumMember(Value = "geometrySource")]
        GeometrySource,
        [EnumMember(Value = "alternateGeoid")]
        AlternateGeoid,
        [EnumMember(Value = "alternateName")]
        AlternateName,
        [EnumMember(Value = "alternateLongName")]
        AlternateLongName,
        [EnumMember(Value = "layerCreationNotes")]
        LayerCreationNotes,
        [EnumMember(Value = "censusClassCodes")]
        CensusClassCodes,
        [EnumMember(Value = "censusFunctionalStatusCodes")]
        CensusFunctionalStatusCodes,
        [EnumMember(Value = "layerTypeCode")]
        LayerTypeCode,
        [EnumMember(Value = "layerGeometry")]
        LayerGeometry
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipCommunityLayerNoOverlapsWholeOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "communityIdNumber desc")]
        CommunityIdNumberDesc,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateCode desc")]
        StateCodeDesc,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "countyCode desc")]
        CountyCodeDesc,
        [EnumMember(Value = "censusGeoid")]
        CensusGeoid,
        [EnumMember(Value = "censusGeoid desc")]
        CensusGeoidDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityName desc")]
        CommunityNameDesc,
        [EnumMember(Value = "communityNameShort")]
        CommunityNameShort,
        [EnumMember(Value = "communityNameShort desc")]
        CommunityNameShortDesc,
        [EnumMember(Value = "censusYear")]
        CensusYear,
        [EnumMember(Value = "censusYear desc")]
        CensusYearDesc,
        [EnumMember(Value = "censusPopulationEntire")]
        CensusPopulationEntire,
        [EnumMember(Value = "censusPopulationEntire desc")]
        CensusPopulationEntireDesc,
        [EnumMember(Value = "censusHousingUnitsEntire")]
        CensusHousingUnitsEntire,
        [EnumMember(Value = "censusHousingUnitsEntire desc")]
        CensusHousingUnitsEntireDesc,
        [EnumMember(Value = "landAreaEntire")]
        LandAreaEntire,
        [EnumMember(Value = "landAreaEntire desc")]
        LandAreaEntireDesc,
        [EnumMember(Value = "censusPopulationPunched")]
        CensusPopulationPunched,
        [EnumMember(Value = "censusPopulationPunched desc")]
        CensusPopulationPunchedDesc,
        [EnumMember(Value = "censusHousingUnitsPunched")]
        CensusHousingUnitsPunched,
        [EnumMember(Value = "censusHousingUnitsPunched desc")]
        CensusHousingUnitsPunchedDesc,
        [EnumMember(Value = "landAreaPunched")]
        LandAreaPunched,
        [EnumMember(Value = "landAreaPunched desc")]
        LandAreaPunchedDesc,
        [EnumMember(Value = "cisType")]
        CisType,
        [EnumMember(Value = "cisType desc")]
        CisTypeDesc,
        [EnumMember(Value = "cisSource")]
        CisSource,
        [EnumMember(Value = "cisSource desc")]
        CisSourceDesc,
        [EnumMember(Value = "geometrySource")]
        GeometrySource,
        [EnumMember(Value = "geometrySource desc")]
        GeometrySourceDesc,
        [EnumMember(Value = "alternateName")]
        AlternateName,
        [EnumMember(Value = "alternateName desc")]
        AlternateNameDesc,
        [EnumMember(Value = "censusClassCodes")]
        CensusClassCodes,
        [EnumMember(Value = "censusClassCodes desc")]
        CensusClassCodesDesc,
        [EnumMember(Value = "censusFunctionalStatusCodes")]
        CensusFunctionalStatusCodes,
        [EnumMember(Value = "censusFunctionalStatusCodes desc")]
        CensusFunctionalStatusCodesDesc,
        [EnumMember(Value = "layerTypeCode")]
        LayerTypeCode,
        [EnumMember(Value = "layerTypeCode desc")]
        LayerTypeCodeDesc,
        [EnumMember(Value = "layerGeometry")]
        LayerGeometry,
        [EnumMember(Value = "layerGeometry desc")]
        LayerGeometryDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipCommunityLayerNoOverlapsWholeSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "censusGeoid")]
        CensusGeoid,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityNameShort")]
        CommunityNameShort,
        [EnumMember(Value = "censusYear")]
        CensusYear,
        [EnumMember(Value = "censusPopulationEntire")]
        CensusPopulationEntire,
        [EnumMember(Value = "censusHousingUnitsEntire")]
        CensusHousingUnitsEntire,
        [EnumMember(Value = "landAreaEntire")]
        LandAreaEntire,
        [EnumMember(Value = "censusPopulationPunched")]
        CensusPopulationPunched,
        [EnumMember(Value = "censusHousingUnitsPunched")]
        CensusHousingUnitsPunched,
        [EnumMember(Value = "landAreaPunched")]
        LandAreaPunched,
        [EnumMember(Value = "cisType")]
        CisType,
        [EnumMember(Value = "cisSource")]
        CisSource,
        [EnumMember(Value = "geometrySource")]
        GeometrySource,
        [EnumMember(Value = "alternateName")]
        AlternateName,
        [EnumMember(Value = "censusClassCodes")]
        CensusClassCodes,
        [EnumMember(Value = "censusFunctionalStatusCodes")]
        CensusFunctionalStatusCodes,
        [EnumMember(Value = "layerTypeCode")]
        LayerTypeCode,
        [EnumMember(Value = "layerGeometry")]
        LayerGeometry
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
        public string ParticipatingInNfip { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipCommunityStatusBookOrderbyInputItem
    {
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "communityIdNumber desc")]
        CommunityIdNumberDesc,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityName desc")]
        CommunityNameDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "initialFloodHazardBoundaryMap")]
        InitialFloodHazardBoundaryMap,
        [EnumMember(Value = "initialFloodHazardBoundaryMap desc")]
        InitialFloodHazardBoundaryMapDesc,
        [EnumMember(Value = "initialFloodInsuranceRateMap")]
        InitialFloodInsuranceRateMap,
        [EnumMember(Value = "initialFloodInsuranceRateMap desc")]
        InitialFloodInsuranceRateMapDesc,
        [EnumMember(Value = "currentlyEffectiveMapDate")]
        CurrentlyEffectiveMapDate,
        [EnumMember(Value = "currentlyEffectiveMapDate desc")]
        CurrentlyEffectiveMapDateDesc,
        [EnumMember(Value = "regularEmergencyProgramDate")]
        RegularEmergencyProgramDate,
        [EnumMember(Value = "regularEmergencyProgramDate desc")]
        RegularEmergencyProgramDateDesc,
        [EnumMember(Value = "tribal")]
        Tribal,
        [EnumMember(Value = "tribal desc")]
        TribalDesc,
        [EnumMember(Value = "participatingInNFIP")]
        ParticipatingInNfip,
        [EnumMember(Value = "participatingInNFIP desc")]
        ParticipatingInNfipDesc,
        [EnumMember(Value = "originalEntryDate")]
        OriginalEntryDate,
        [EnumMember(Value = "originalEntryDate desc")]
        OriginalEntryDateDesc,
        [EnumMember(Value = "classRatingEffectiveDate")]
        ClassRatingEffectiveDate,
        [EnumMember(Value = "classRatingEffectiveDate desc")]
        ClassRatingEffectiveDateDesc,
        [EnumMember(Value = "classRating")]
        ClassRating,
        [EnumMember(Value = "classRating desc")]
        ClassRatingDesc,
        [EnumMember(Value = "sfhaDiscount")]
        SfhaDiscount,
        [EnumMember(Value = "sfhaDiscount desc")]
        SfhaDiscountDesc,
        [EnumMember(Value = "nonSfhaDiscount")]
        NonSfhaDiscount,
        [EnumMember(Value = "nonSfhaDiscount desc")]
        NonSfhaDiscountDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipCommunityStatusBookSelectInputItem
    {
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "initialFloodHazardBoundaryMap")]
        InitialFloodHazardBoundaryMap,
        [EnumMember(Value = "initialFloodInsuranceRateMap")]
        InitialFloodInsuranceRateMap,
        [EnumMember(Value = "currentlyEffectiveMapDate")]
        CurrentlyEffectiveMapDate,
        [EnumMember(Value = "regularEmergencyProgramDate")]
        RegularEmergencyProgramDate,
        [EnumMember(Value = "tribal")]
        Tribal,
        [EnumMember(Value = "participatingInNFIP")]
        ParticipatingInNfip,
        [EnumMember(Value = "originalEntryDate")]
        OriginalEntryDate,
        [EnumMember(Value = "classRatingEffectiveDate")]
        ClassRatingEffectiveDate,
        [EnumMember(Value = "classRating")]
        ClassRating,
        [EnumMember(Value = "sfhaDiscount")]
        SfhaDiscount,
        [EnumMember(Value = "nonSfhaDiscount")]
        NonSfhaDiscount,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh
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
        public bool PostFirmConstructionIndicator { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipMultipleLossPropertiesOrderbyInputItem
    {
        [EnumMember(Value = "fipsCountyCode")]
        FipsCountyCode,
        [EnumMember(Value = "fipsCountyCode desc")]
        FipsCountyCodeDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "stateAbbreviation desc")]
        StateAbbreviationDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "zipCode desc")]
        ZipCodeDesc,
        [EnumMember(Value = "reportedCity")]
        ReportedCity,
        [EnumMember(Value = "reportedCity desc")]
        ReportedCityDesc,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "communityIdNumber desc")]
        CommunityIdNumberDesc,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "communityName desc")]
        CommunityNameDesc,
        [EnumMember(Value = "censusBlockGroup")]
        CensusBlockGroup,
        [EnumMember(Value = "censusBlockGroup desc")]
        CensusBlockGroupDesc,
        [EnumMember(Value = "nfipRl")]
        NfipRl,
        [EnumMember(Value = "nfipRl desc")]
        NfipRlDesc,
        [EnumMember(Value = "nfipSrl")]
        NfipSrl,
        [EnumMember(Value = "nfipSrl desc")]
        NfipSrlDesc,
        [EnumMember(Value = "fmaRl")]
        FmaRl,
        [EnumMember(Value = "fmaRl desc")]
        FmaRlDesc,
        [EnumMember(Value = "fmaSrl")]
        FmaSrl,
        [EnumMember(Value = "fmaSrl desc")]
        FmaSrlDesc,
        [EnumMember(Value = "asOfDate")]
        AsOfDate,
        [EnumMember(Value = "asOfDate desc")]
        AsOfDateDesc,
        [EnumMember(Value = "floodZone")]
        FloodZone,
        [EnumMember(Value = "floodZone desc")]
        FloodZoneDesc,
        [EnumMember(Value = "latitude")]
        Latitude,
        [EnumMember(Value = "latitude desc")]
        LatitudeDesc,
        [EnumMember(Value = "longitude")]
        Longitude,
        [EnumMember(Value = "longitude desc")]
        LongitudeDesc,
        [EnumMember(Value = "occupancyType")]
        OccupancyType,
        [EnumMember(Value = "occupancyType desc")]
        OccupancyTypeDesc,
        [EnumMember(Value = "originalConstructionDate")]
        OriginalConstructionDate,
        [EnumMember(Value = "originalConstructionDate desc")]
        OriginalConstructionDateDesc,
        [EnumMember(Value = "originalNBDate")]
        OriginalNBDate,
        [EnumMember(Value = "originalNBDate desc")]
        OriginalNBDateDesc,
        [EnumMember(Value = "postFIRMConstructionIndicator")]
        PostFirmConstructionIndicator,
        [EnumMember(Value = "postFIRMConstructionIndicator desc")]
        PostFirmConstructionIndicatorDesc,
        [EnumMember(Value = "primaryResidenceIndicator")]
        PrimaryResidenceIndicator,
        [EnumMember(Value = "primaryResidenceIndicator desc")]
        PrimaryResidenceIndicatorDesc,
        [EnumMember(Value = "mitigatedIndicator")]
        MitigatedIndicator,
        [EnumMember(Value = "mitigatedIndicator desc")]
        MitigatedIndicatorDesc,
        [EnumMember(Value = "insuredIndicator")]
        InsuredIndicator,
        [EnumMember(Value = "insuredIndicator desc")]
        InsuredIndicatorDesc,
        [EnumMember(Value = "totalLosses")]
        TotalLosses,
        [EnumMember(Value = "totalLosses desc")]
        TotalLossesDesc,
        [EnumMember(Value = "mostRecentDateofLoss")]
        MostRecentDateofLoss,
        [EnumMember(Value = "mostRecentDateofLoss desc")]
        MostRecentDateofLossDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipMultipleLossPropertiesSelectInputItem
    {
        [EnumMember(Value = "fipsCountyCode")]
        FipsCountyCode,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "reportedCity")]
        ReportedCity,
        [EnumMember(Value = "communityIdNumber")]
        CommunityIdNumber,
        [EnumMember(Value = "communityName")]
        CommunityName,
        [EnumMember(Value = "censusBlockGroup")]
        CensusBlockGroup,
        [EnumMember(Value = "nfipRl")]
        NfipRl,
        [EnumMember(Value = "nfipSrl")]
        NfipSrl,
        [EnumMember(Value = "fmaRl")]
        FmaRl,
        [EnumMember(Value = "fmaSrl")]
        FmaSrl,
        [EnumMember(Value = "asOfDate")]
        AsOfDate,
        [EnumMember(Value = "floodZone")]
        FloodZone,
        [EnumMember(Value = "latitude")]
        Latitude,
        [EnumMember(Value = "longitude")]
        Longitude,
        [EnumMember(Value = "occupancyType")]
        OccupancyType,
        [EnumMember(Value = "originalConstructionDate")]
        OriginalConstructionDate,
        [EnumMember(Value = "originalNBDate")]
        OriginalNBDate,
        [EnumMember(Value = "postFIRMConstructionIndicator")]
        PostFirmConstructionIndicator,
        [EnumMember(Value = "primaryResidenceIndicator")]
        PrimaryResidenceIndicator,
        [EnumMember(Value = "mitigatedIndicator")]
        MitigatedIndicator,
        [EnumMember(Value = "insuredIndicator")]
        InsuredIndicator,
        [EnumMember(Value = "totalLosses")]
        TotalLosses,
        [EnumMember(Value = "mostRecentDateofLoss")]
        MostRecentDateofLoss,
        [EnumMember(Value = "id")]
        Id
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipResidentialPenetrationRatesOrderbyInputItem
    {
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "resPenetrationRate")]
        ResPenetrationRate,
        [EnumMember(Value = "resPenetrationRate desc")]
        ResPenetrationRateDesc,
        [EnumMember(Value = "resContractsInForce")]
        ResContractsInForce,
        [EnumMember(Value = "resContractsInForce desc")]
        ResContractsInForceDesc,
        [EnumMember(Value = "totalResStructures")]
        TotalResStructures,
        [EnumMember(Value = "totalResStructures desc")]
        TotalResStructuresDesc,
        [EnumMember(Value = "fipsCode")]
        FipsCode,
        [EnumMember(Value = "fipsCode desc")]
        FipsCodeDesc,
        [EnumMember(Value = "asOfDate")]
        AsOfDate,
        [EnumMember(Value = "asOfDate desc")]
        AsOfDateDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1NfipResidentialPenetrationRatesSelectInputItem
    {
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "resPenetrationRate")]
        ResPenetrationRate,
        [EnumMember(Value = "resContractsInForce")]
        ResContractsInForce,
        [EnumMember(Value = "totalResStructures")]
        TotalResStructures,
        [EnumMember(Value = "fipsCode")]
        FipsCode,
        [EnumMember(Value = "asOfDate")]
        AsOfDate,
        [EnumMember(Value = "id")]
        Id
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1PublicAssistanceApplicantsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "applicantId")]
        ApplicantId,
        [EnumMember(Value = "applicantId desc")]
        ApplicantIdDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "applicantName desc")]
        ApplicantNameDesc,
        [EnumMember(Value = "addressLine1")]
        AddressLine1,
        [EnumMember(Value = "addressLine1 desc")]
        AddressLine1Desc,
        [EnumMember(Value = "addressLine2")]
        AddressLine2,
        [EnumMember(Value = "addressLine2 desc")]
        AddressLine2Desc,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "city desc")]
        CityDesc,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "zipCode desc")]
        ZipCodeDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1PublicAssistanceApplicantsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "applicantId")]
        ApplicantId,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "addressLine1")]
        AddressLine1,
        [EnumMember(Value = "addressLine2")]
        AddressLine2,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "zipCode")]
        ZipCode,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1PublicAssistanceApplicantsProgramDeliveriesOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "declarationType")]
        DeclarationType,
        [EnumMember(Value = "declarationType desc")]
        DeclarationTypeDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateCode desc")]
        StateCodeDesc,
        [EnumMember(Value = "stateName")]
        StateName,
        [EnumMember(Value = "stateName desc")]
        StateNameDesc,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "declarationDate desc")]
        DeclarationDateDesc,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "incidentType desc")]
        IncidentTypeDesc,
        [EnumMember(Value = "declarationTitle")]
        DeclarationTitle,
        [EnumMember(Value = "declarationTitle desc")]
        DeclarationTitleDesc,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "consolidatedResourceCenter")]
        ConsolidatedResourceCenter,
        [EnumMember(Value = "consolidatedResourceCenter desc")]
        ConsolidatedResourceCenterDesc,
        [EnumMember(Value = "countyApplicantJurisdiction")]
        CountyApplicantJurisdiction,
        [EnumMember(Value = "countyApplicantJurisdiction desc")]
        CountyApplicantJurisdictionDesc,
        [EnumMember(Value = "utilizingDirectApplication")]
        UtilizingDirectApplication,
        [EnumMember(Value = "utilizingDirectApplication desc")]
        UtilizingDirectApplicationDesc,
        [EnumMember(Value = "applicantIdGm")]
        ApplicantIdGm,
        [EnumMember(Value = "applicantIdGm desc")]
        ApplicantIdGmDesc,
        [EnumMember(Value = "applicantIdEmmie")]
        ApplicantIdEmmie,
        [EnumMember(Value = "applicantIdEmmie desc")]
        ApplicantIdEmmieDesc,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "applicantName desc")]
        ApplicantNameDesc,
        [EnumMember(Value = "applicantType")]
        ApplicantType,
        [EnumMember(Value = "applicantType desc")]
        ApplicantTypeDesc,
        [EnumMember(Value = "isPnp")]
        IsPnp,
        [EnumMember(Value = "isPnp desc")]
        IsPnpDesc,
        [EnumMember(Value = "applicantStatus")]
        ApplicantStatus,
        [EnumMember(Value = "applicantStatus desc")]
        ApplicantStatusDesc,
        [EnumMember(Value = "applicantProcessStatus")]
        ApplicantProcessStatus,
        [EnumMember(Value = "applicantProcessStatus desc")]
        ApplicantProcessStatusDesc,
        [EnumMember(Value = "numberActiveDamages")]
        NumberActiveDamages,
        [EnumMember(Value = "numberActiveDamages desc")]
        NumberActiveDamagesDesc,
        [EnumMember(Value = "totalAppDamageCost")]
        TotalAppDamageCost,
        [EnumMember(Value = "totalAppDamageCost desc")]
        TotalAppDamageCostDesc,
        [EnumMember(Value = "numberActiveProjects")]
        NumberActiveProjects,
        [EnumMember(Value = "numberActiveProjects desc")]
        NumberActiveProjectsDesc,
        [EnumMember(Value = "currentProjectCost")]
        CurrentProjectCost,
        [EnumMember(Value = "currentProjectCost desc")]
        CurrentProjectCostDesc,
        [EnumMember(Value = "numberPhase2Projects")]
        NumberPhase2Projects,
        [EnumMember(Value = "numberPhase2Projects desc")]
        NumberPhase2ProjectsDesc,
        [EnumMember(Value = "phase2ProjectCost")]
        Phase2ProjectCost,
        [EnumMember(Value = "phase2ProjectCost desc")]
        Phase2ProjectCostDesc,
        [EnumMember(Value = "numberPhase3Projects")]
        NumberPhase3Projects,
        [EnumMember(Value = "numberPhase3Projects desc")]
        NumberPhase3ProjectsDesc,
        [EnumMember(Value = "phase3ProjectCost")]
        Phase3ProjectCost,
        [EnumMember(Value = "phase3ProjectCost desc")]
        Phase3ProjectCostDesc,
        [EnumMember(Value = "numberPhase4Projects")]
        NumberPhase4Projects,
        [EnumMember(Value = "numberPhase4Projects desc")]
        NumberPhase4ProjectsDesc,
        [EnumMember(Value = "phase4ProjectCost")]
        Phase4ProjectCost,
        [EnumMember(Value = "phase4ProjectCost desc")]
        Phase4ProjectCostDesc,
        [EnumMember(Value = "numberPhase5Projects")]
        NumberPhase5Projects,
        [EnumMember(Value = "numberPhase5Projects desc")]
        NumberPhase5ProjectsDesc,
        [EnumMember(Value = "phase5ProjectCost")]
        Phase5ProjectCost,
        [EnumMember(Value = "phase5ProjectCost desc")]
        Phase5ProjectCostDesc,
        [EnumMember(Value = "numberObligatedProjects")]
        NumberObligatedProjects,
        [EnumMember(Value = "numberObligatedProjects desc")]
        NumberObligatedProjectsDesc,
        [EnumMember(Value = "federalShareObligated")]
        FederalShareObligated,
        [EnumMember(Value = "federalShareObligated desc")]
        FederalShareObligatedDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1PublicAssistanceApplicantsProgramDeliveriesSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "declarationType")]
        DeclarationType,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateName")]
        StateName,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "declarationTitle")]
        DeclarationTitle,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "consolidatedResourceCenter")]
        ConsolidatedResourceCenter,
        [EnumMember(Value = "countyApplicantJurisdiction")]
        CountyApplicantJurisdiction,
        [EnumMember(Value = "utilizingDirectApplication")]
        UtilizingDirectApplication,
        [EnumMember(Value = "applicantIdGm")]
        ApplicantIdGm,
        [EnumMember(Value = "applicantIdEmmie")]
        ApplicantIdEmmie,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "applicantType")]
        ApplicantType,
        [EnumMember(Value = "isPnp")]
        IsPnp,
        [EnumMember(Value = "applicantStatus")]
        ApplicantStatus,
        [EnumMember(Value = "applicantProcessStatus")]
        ApplicantProcessStatus,
        [EnumMember(Value = "numberActiveDamages")]
        NumberActiveDamages,
        [EnumMember(Value = "totalAppDamageCost")]
        TotalAppDamageCost,
        [EnumMember(Value = "numberActiveProjects")]
        NumberActiveProjects,
        [EnumMember(Value = "currentProjectCost")]
        CurrentProjectCost,
        [EnumMember(Value = "numberPhase2Projects")]
        NumberPhase2Projects,
        [EnumMember(Value = "phase2ProjectCost")]
        Phase2ProjectCost,
        [EnumMember(Value = "numberPhase3Projects")]
        NumberPhase3Projects,
        [EnumMember(Value = "phase3ProjectCost")]
        Phase3ProjectCost,
        [EnumMember(Value = "numberPhase4Projects")]
        NumberPhase4Projects,
        [EnumMember(Value = "phase4ProjectCost")]
        Phase4ProjectCost,
        [EnumMember(Value = "numberPhase5Projects")]
        NumberPhase5Projects,
        [EnumMember(Value = "phase5ProjectCost")]
        Phase5ProjectCost,
        [EnumMember(Value = "numberObligatedProjects")]
        NumberObligatedProjects,
        [EnumMember(Value = "federalShareObligated")]
        FederalShareObligated,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1PublicAssistanceFundedProjectsDetailsOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "declarationDate desc")]
        DeclarationDateDesc,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "incidentType desc")]
        IncidentTypeDesc,
        [EnumMember(Value = "pwNumber")]
        PwNumber,
        [EnumMember(Value = "pwNumber desc")]
        PwNumberDesc,
        [EnumMember(Value = "applicationTitle")]
        ApplicationTitle,
        [EnumMember(Value = "applicationTitle desc")]
        ApplicationTitleDesc,
        [EnumMember(Value = "applicantId")]
        ApplicantId,
        [EnumMember(Value = "applicantId desc")]
        ApplicantIdDesc,
        [EnumMember(Value = "damageCategoryCode")]
        DamageCategoryCode,
        [EnumMember(Value = "damageCategoryCode desc")]
        DamageCategoryCodeDesc,
        [EnumMember(Value = "dcc")]
        Dcc,
        [EnumMember(Value = "dcc desc")]
        DccDesc,
        [EnumMember(Value = "damageCategory")]
        DamageCategory,
        [EnumMember(Value = "damageCategory desc")]
        DamageCategoryDesc,
        [EnumMember(Value = "projectSize")]
        ProjectSize,
        [EnumMember(Value = "projectSize desc")]
        ProjectSizeDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "countyCode desc")]
        CountyCodeDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateCode desc")]
        StateCodeDesc,
        [EnumMember(Value = "stateNumberCode")]
        StateNumberCode,
        [EnumMember(Value = "stateNumberCode desc")]
        StateNumberCodeDesc,
        [EnumMember(Value = "projectAmount")]
        ProjectAmount,
        [EnumMember(Value = "projectAmount desc")]
        ProjectAmountDesc,
        [EnumMember(Value = "federalShareObligated")]
        FederalShareObligated,
        [EnumMember(Value = "federalShareObligated desc")]
        FederalShareObligatedDesc,
        [EnumMember(Value = "totalObligated")]
        TotalObligated,
        [EnumMember(Value = "totalObligated desc")]
        TotalObligatedDesc,
        [EnumMember(Value = "obligatedDate")]
        ObligatedDate,
        [EnumMember(Value = "obligatedDate desc")]
        ObligatedDateDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1PublicAssistanceFundedProjectsDetailsSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "pwNumber")]
        PwNumber,
        [EnumMember(Value = "applicationTitle")]
        ApplicationTitle,
        [EnumMember(Value = "applicantId")]
        ApplicantId,
        [EnumMember(Value = "damageCategoryCode")]
        DamageCategoryCode,
        [EnumMember(Value = "dcc")]
        Dcc,
        [EnumMember(Value = "damageCategory")]
        DamageCategory,
        [EnumMember(Value = "projectSize")]
        ProjectSize,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "countyCode")]
        CountyCode,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "stateCode")]
        StateCode,
        [EnumMember(Value = "stateNumberCode")]
        StateNumberCode,
        [EnumMember(Value = "projectAmount")]
        ProjectAmount,
        [EnumMember(Value = "federalShareObligated")]
        FederalShareObligated,
        [EnumMember(Value = "totalObligated")]
        TotalObligated,
        [EnumMember(Value = "obligatedDate")]
        ObligatedDate,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1PublicAssistanceFundedProjectsSummariesOrderbyInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "declarationDate desc")]
        DeclarationDateDesc,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "incidentType desc")]
        IncidentTypeDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "applicantName desc")]
        ApplicantNameDesc,
        [EnumMember(Value = "educationApplicant")]
        EducationApplicant,
        [EnumMember(Value = "educationApplicant desc")]
        EducationApplicantDesc,
        [EnumMember(Value = "numberOfProjects")]
        NumberOfProjects,
        [EnumMember(Value = "numberOfProjects desc")]
        NumberOfProjectsDesc,
        [EnumMember(Value = "federalObligatedAmount")]
        FederalObligatedAmount,
        [EnumMember(Value = "federalObligatedAmount desc")]
        FederalObligatedAmountDesc,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "lastRefresh desc")]
        LastRefreshDesc,
        [EnumMember(Value = "hash")]
        Hash,
        [EnumMember(Value = "hash desc")]
        HashDesc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV1PublicAssistanceFundedProjectsSummariesSelectInputItem
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "educationApplicant")]
        EducationApplicant,
        [EnumMember(Value = "numberOfProjects")]
        NumberOfProjects,
        [EnumMember(Value = "federalObligatedAmount")]
        FederalObligatedAmount,
        [EnumMember(Value = "lastRefresh")]
        LastRefresh,
        [EnumMember(Value = "hash")]
        Hash
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2PublicAssistanceGrantAwardActivitiesOrderbyInputItem
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetV2PublicAssistanceGrantAwardActivitiesSelectInputItem
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