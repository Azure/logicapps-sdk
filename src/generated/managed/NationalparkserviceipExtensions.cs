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
        public IBodyWorkflowAction<JToken> GetActivities([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetActvitiesParks([WorkflowExpression] Func<string[]> id = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string[]> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/activities/parks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetAlerts([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetAmenities([WorkflowExpression] Func<string[]> id = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/amenities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetAmenitiesParksplaces([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> id = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/amenities/parksplaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetAmenitiesParksvisitorcenters([WorkflowExpression] Func<string> parkCode = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string[]> sort = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/amenities/parksvisitorcenters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetArticles([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/articles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetCampgrounds([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/campgrounds";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetEvents([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> organization = null, [WorkflowExpression] Func<string[]> subject = null, [WorkflowExpression] Func<string[]> portal = null, [WorkflowExpression] Func<string[]> tagsAll = null, [WorkflowExpression] Func<string[]> tagsOne = null, [WorkflowExpression] Func<string[]> tagsNone = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<string> dateStart = null, [WorkflowExpression] Func<string> dateEnd = null, [WorkflowExpression] Func<string[]> eventType = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<bool> expandRecurring = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(organization, nameof(organization), required: false);
            SourceExpression.Validate(subject, nameof(subject), required: false);
            SourceExpression.Validate(portal, nameof(portal), required: false);
            SourceExpression.Validate(tagsAll, nameof(tagsAll), required: false);
            SourceExpression.Validate(tagsOne, nameof(tagsOne), required: false);
            SourceExpression.Validate(tagsNone, nameof(tagsNone), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(dateStart, nameof(dateStart), required: false);
            SourceExpression.Validate(dateEnd, nameof(dateEnd), required: false);
            SourceExpression.Validate(eventType, nameof(eventType), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: false);
            SourceExpression.Validate(expandRecurring, nameof(expandRecurring), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (organization != null)
                    callPayload.Queries["organization"] = SourceExpressionConverter.ConvertO(organization);
                if (subject != null)
                    callPayload.Queries["subject"] = SourceExpressionConverter.ConvertO(subject);
                if (portal != null)
                    callPayload.Queries["portal"] = SourceExpressionConverter.ConvertO(portal);
                if (tagsAll != null)
                    callPayload.Queries["tagsAll"] = SourceExpressionConverter.ConvertO(tagsAll);
                if (tagsOne != null)
                    callPayload.Queries["tagsOne"] = SourceExpressionConverter.ConvertO(tagsOne);
                if (tagsNone != null)
                    callPayload.Queries["tagsNone"] = SourceExpressionConverter.ConvertO(tagsNone);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (dateStart != null)
                    callPayload.Queries["dateStart"] = SourceExpressionConverter.ConvertO(dateStart);
                if (dateEnd != null)
                    callPayload.Queries["dateEnd"] = SourceExpressionConverter.ConvertO(dateEnd);
                if (eventType != null)
                    callPayload.Queries["eventType"] = SourceExpressionConverter.ConvertO(eventType);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (pageNumber != null)
                    callPayload.Queries["pageNumber"] = SourceExpressionConverter.ConvertO(pageNumber);
                if (expandRecurring != null)
                    callPayload.Queries["expandRecurring"] = SourceExpressionConverter.ConvertO(expandRecurring);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetLessonPlans([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string[]> sort = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lessonplans";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetNewsReleases([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string[]> sort = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/newsreleases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetPark([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string[]> sort = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/parks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetPassportstamplocations([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/passportstamplocations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetPeople([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetPlaces([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/places";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetThingstodo([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> parkCode = null, [WorkflowExpression] Func<string> stateCode = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/thingstodo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetTopics([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/topics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetTopicsParks([WorkflowExpression] Func<string[]> id = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/topics/parks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetTours([WorkflowExpression] Func<string[]> id = null, [WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tours";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetVisitorCenters([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/visitorcenters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalparkserviceip")]
        public IBodyWorkflowAction<JToken> GetWebcams([WorkflowExpression] Func<string[]> parkCode = null, [WorkflowExpression] Func<string[]> stateCode = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> q = null)
        {
            SourceExpression.Validate(parkCode, nameof(parkCode), required: false);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(q, nameof(q), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webcams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parkCode != null)
                    callPayload.Queries["parkCode"] = SourceExpressionConverter.ConvertO(parkCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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