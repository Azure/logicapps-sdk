//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nationalparkserviceip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NationalparkserviceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetActivities(Expression<Func<string>> id = null, Expression<Func<string>> q = null, Expression<Func<string>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/activities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetActvitiesParks(Expression<Func<string[]>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string[]>> sort = null)
        {
            var apiCallPath = "/activities/parks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetAlerts(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = "/alerts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetAmenities(Expression<Func<string[]>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null)
        {
            var apiCallPath = "/amenities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetAmenitiesParksplaces(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/amenities/parksplaces";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetAmenitiesParksvisitorcenters(Expression<Func<string>> parkCode = null, Expression<Func<string>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string[]>> sort = null)
        {
            var apiCallPath = "/amenities/parksvisitorcenters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetArticles(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = "/articles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetCampgrounds(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = "/campgrounds";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetEvents(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> organization = null, Expression<Func<string[]>> subject = null, Expression<Func<string[]>> portal = null, Expression<Func<string[]>> tagsAll = null, Expression<Func<string[]>> tagsOne = null, Expression<Func<string[]>> tagsNone = null, Expression<Func<string[]>> stateCode = null, Expression<Func<string>> dateStart = null, Expression<Func<string>> dateEnd = null, Expression<Func<string[]>> eventType = null, Expression<Func<string>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> pageNumber = null, Expression<Func<bool>> expandRecurring = null)
        {
            var apiCallPath = "/events";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (organization != null)
                callPayload.Queries["organization"] = ExpressionConverter.Convert(organization);
            if (subject != null)
                callPayload.Queries["subject"] = ExpressionConverter.Convert(subject);
            if (portal != null)
                callPayload.Queries["portal"] = ExpressionConverter.Convert(portal);
            if (tagsAll != null)
                callPayload.Queries["tagsAll"] = ExpressionConverter.Convert(tagsAll);
            if (tagsOne != null)
                callPayload.Queries["tagsOne"] = ExpressionConverter.Convert(tagsOne);
            if (tagsNone != null)
                callPayload.Queries["tagsNone"] = ExpressionConverter.Convert(tagsNone);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (dateStart != null)
                callPayload.Queries["dateStart"] = ExpressionConverter.Convert(dateStart);
            if (dateEnd != null)
                callPayload.Queries["dateEnd"] = ExpressionConverter.Convert(dateEnd);
            if (eventType != null)
                callPayload.Queries["eventType"] = ExpressionConverter.Convert(eventType);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageNumber != null)
                callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(pageNumber);
            if (expandRecurring != null)
                callPayload.Queries["expandRecurring"] = ExpressionConverter.Convert(expandRecurring);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetLessonPlans(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null, Expression<Func<string[]>> sort = null)
        {
            var apiCallPath = "/lessonplans";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetNewsReleases(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null, Expression<Func<string[]>> sort = null)
        {
            var apiCallPath = "/newsreleases";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetPark(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null, Expression<Func<string[]>> sort = null)
        {
            var apiCallPath = "/parks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetPassportstamplocations(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null)
        {
            var apiCallPath = "/passportstamplocations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetPeople(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = "/people";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetPlaces(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = "/places";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetThingstodo(Expression<Func<string>> id = null, Expression<Func<string>> parkCode = null, Expression<Func<string>> stateCode = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<string>> start = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/thingstodo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetTopics(Expression<Func<string>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/topics";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetTopicsParks(Expression<Func<string[]>> id = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/topics/parks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetTours(Expression<Func<string[]>> id = null, Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<string>> q = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null)
        {
            var apiCallPath = "/tours";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetVisitorCenters(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = "/visitorcenters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetWebcams(Expression<Func<string[]>> parkCode = null, Expression<Func<string[]>> stateCode = null, Expression<Func<string>> id = null, Expression<Func<int>> limit = null, Expression<Func<int>> start = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = "/webcams";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (parkCode != null)
                callPayload.Queries["parkCode"] = ExpressionConverter.Convert(parkCode);
            if (stateCode != null)
                callPayload.Queries["stateCode"] = ExpressionConverter.Convert(stateCode);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<JToken>(callPayload);
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