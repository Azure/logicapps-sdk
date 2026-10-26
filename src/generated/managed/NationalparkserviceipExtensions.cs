//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nationalparkserviceip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NationalparkserviceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetActivities(Expression<Func<string>> id = null, Expression<Func<string>> q = null, Expression<Func<string>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetActvitiesParks(Expression<Func<string[]>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string[]>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/activities/parks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAlerts(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAmenities(Expression<Func<string[]>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/amenities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAmenitiesParksplaces(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> sort = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/amenities/parksplaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAmenitiesParksvisitorcenters(Expression<Func<string>> parkCode = null, Expression<Func<string>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string[]>> sort = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/amenities/parksvisitorcenters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetArticles(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/articles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetCampgrounds(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/campgrounds";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetEvents(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> organization = null, Expression<Func<string[]>> subject = null, Expression<Func<string[]>> portal = null, Expression<Func<string[]>> tagsAll = null, Expression<Func<string[]>> tagsOne = null, Expression<Func<string[]>> tagsNone = null, Expression<Func<string[]>> stateCode = null, Expression<Func<string>> dateStart = null, Expression<Func<string>> dateEnd = null, Expression<Func<string[]>> eventType = null, Expression<Func<string>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> pageNumber = null, Expression<Func<bool>> expandRecurring = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_subject = WorkflowExpression.Compile(subject, nameof(subject), required: false);
            var __workflow_portal = WorkflowExpression.Compile(portal, nameof(portal), required: false);
            var __workflow_tagsAll = WorkflowExpression.Compile(tagsAll, nameof(tagsAll), required: false);
            var __workflow_tagsOne = WorkflowExpression.Compile(tagsOne, nameof(tagsOne), required: false);
            var __workflow_tagsNone = WorkflowExpression.Compile(tagsNone, nameof(tagsNone), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_dateStart = WorkflowExpression.Compile(dateStart, nameof(dateStart), required: false);
            var __workflow_dateEnd = WorkflowExpression.Compile(dateEnd, nameof(dateEnd), required: false);
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_expandRecurring = WorkflowExpression.Compile(expandRecurring, nameof(expandRecurring), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_organization != null)
                    callPayload.Queries["organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(__workflow_subject);
                if (__workflow_portal != null)
                    callPayload.Queries["portal"] = ExpressionConverter.Convert(__workflow_portal);
                if (__workflow_tagsAll != null)
                    callPayload.Queries["tagsAll"] = ExpressionConverter.Convert(__workflow_tagsAll);
                if (__workflow_tagsOne != null)
                    callPayload.Queries["tagsOne"] = ExpressionConverter.Convert(__workflow_tagsOne);
                if (__workflow_tagsNone != null)
                    callPayload.Queries["tagsNone"] = ExpressionConverter.Convert(__workflow_tagsNone);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_dateStart != null)
                    callPayload.Queries["dateStart"] = ExpressionConverter.Convert(__workflow_dateStart);
                if (__workflow_dateEnd != null)
                    callPayload.Queries["dateEnd"] = ExpressionConverter.Convert(__workflow_dateEnd);
                if (__workflow_eventType != null)
                    callPayload.Queries["eventType"] = ExpressionConverter.Convert(__workflow_eventType);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                if (__workflow_expandRecurring != null)
                    callPayload.Queries["expandRecurring"] = ExpressionConverter.Convert(__workflow_expandRecurring);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetLessonPlans(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null, Expression<Func<string[]>> sort = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lessonplans";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetNewsReleases(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null, Expression<Func<string[]>> sort = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/newsreleases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetPark(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null, Expression<Func<string[]>> sort = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/parks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetPassportstamplocations(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/passportstamplocations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetPeople(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetPlaces(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/places";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetThingstodo(Expression<Func<string>> id = null, Expression<Func<string>> parkCode = null, Expression<Func<string>> stateCode = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<string>> start = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/thingstodo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetTopics(Expression<Func<string>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/topics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetTopicsParks(Expression<Func<string[]>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/topics/parks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetTours(Expression<Func<string[]>> id = null, Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tours";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetVisitorCenters(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/visitorcenters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetWebcams(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<string>> id = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var __workflow_parkCode = WorkflowExpression.Compile(parkCode, nameof(parkCode), required: false);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webcams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parkCode != null)
                    callPayload.Queries["parkCode"] = ExpressionConverter.Convert(__workflow_parkCode);
                if (__workflow_stateCode != null)
                    callPayload.Queries["stateCode"] = ExpressionConverter.Convert(__workflow_stateCode);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class NationalparkserviceipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nationalparkserviceip;

    public partial class WorkflowManagedActions
    {
        public NationalparkserviceipActions Nationalparkserviceip(string connectionId) => new NationalparkserviceipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NationalparkserviceipTriggers Nationalparkserviceip(string connectionId) => new NationalparkserviceipTriggers(connectionId);
    }
}