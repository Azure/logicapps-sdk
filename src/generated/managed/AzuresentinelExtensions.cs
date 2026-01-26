//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuresentinel
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuresentinelActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<BatchResponseAccount> GetAccounts(Expression<Func<string>> body = null)
        {
            var apiCallPath = "/entities/account";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BatchResponseAccount>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<OldIncident> GetIncident(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> alertId)
        {
            var apiCallPath = String.Format("/Cases/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(alertId, 1), ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OldIncident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<Incident> GetIncidentByAlertIdV2(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> alertId)
        {
            var apiCallPath = String.Format("/Incidents/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/alerts/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(alertId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Incident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<Incident> GetIncidentV2(Expression<Func<string>> bodyincidentArmId)
        {
            var apiCallPath = "/Incidents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["incidentArmId"] = ExpressionConverter.ConvertO(bodyincidentArmId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Incident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<Incident> UpdateIncident(Expression<Func<string>> bodyincidentArmId, Expression<Func<ClientTags[]>> bodytagsToAddtagsToAdd, Expression<Func<ClientTags[]>> bodytagsToRemovetagsToRemove, Expression<Func<bodyownerActionInput>> bodyownerAction = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodyseverityInput>> bodyseverity = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<object>> bodyclassification = null)
        {
            var apiCallPath = "/Incidents";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["incidentArmId"] = ExpressionConverter.ConvertO(bodyincidentArmId);
            var tagsToAddObject = new JObject();
            var tagsToAddObjectpropCount = 0;
            tagsToAddObjectpropCount++;
            tagsToAddObject["TagsToAdd"] = ExpressionConverter.ConvertO(bodytagsToAddtagsToAdd);
            if (tagsToAddObjectpropCount > 0)
            {
                body["tagsToAdd"] = tagsToAddObject;
                bodypropCount++;
            }

            var tagsToRemoveObject = new JObject();
            var tagsToRemoveObjectpropCount = 0;
            tagsToRemoveObjectpropCount++;
            tagsToRemoveObject["TagsToRemove"] = ExpressionConverter.ConvertO(bodytagsToRemovetagsToRemove);
            if (tagsToRemoveObjectpropCount > 0)
            {
                body["tagsToRemove"] = tagsToRemoveObject;
                bodypropCount++;
            }

            if (bodyownerAction != null)
            {
                body["ownerAction"] = ExpressionConverter.ConvertO(bodyownerAction);
                bodypropCount++;
            }

            if (bodyowner != null)
            {
                body["owner"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyseverity != null)
            {
                body["severity"] = ExpressionConverter.ConvertO(bodyseverity);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyclassification != null)
            {
                body["classification"] = ExpressionConverter.ConvertO(bodyclassification);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Incident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<Incident> CreateIncident(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceName, Expression<Func<string>> bodytitle, Expression<Func<ClientTags[]>> bodytagsToAddtagsToAdd, Expression<Func<string>> bodydescription = null, Expression<Func<bodyseverityInput>> bodyseverity = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<object>> bodyclassification = null, Expression<Func<string>> bodyowner = null, Expression<Func<bodyownerActionInput>> bodyownerAction = null)
        {
            var apiCallPath = String.Format("/Incidents/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyseverity != null)
            {
                body["severity"] = ExpressionConverter.ConvertO(bodyseverity);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyclassification != null)
            {
                body["classification"] = ExpressionConverter.ConvertO(bodyclassification);
                bodypropCount++;
            }

            if (bodyowner != null)
            {
                body["owner"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            if (bodyownerAction != null)
            {
                body["ownerAction"] = ExpressionConverter.ConvertO(bodyownerAction);
                bodypropCount++;
            }

            var tagsToAddObject = new JObject();
            var tagsToAddObjectpropCount = 0;
            tagsToAddObjectpropCount++;
            tagsToAddObject["TagsToAdd"] = ExpressionConverter.ConvertO(bodytagsToAddtagsToAdd);
            if (tagsToAddObjectpropCount > 0)
            {
                body["tagsToAdd"] = tagsToAddObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Incident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<IncidentComment> AddIncidentCommentV3(Expression<Func<string>> bodyincidentArmId, Expression<Func<string>> bodymessage)
        {
            var apiCallPath = "/Incidents/Comment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["incidentArmId"] = ExpressionConverter.ConvertO(bodyincidentArmId);
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IncidentComment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<IncidentTask> AddIncidentTask(Expression<Func<string>> bodyincidentArmId, Expression<Func<string>> bodytaskTitle, Expression<Func<string>> bodytaskDescription = null)
        {
            var apiCallPath = "/Incidents/CreateTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["incidentArmId"] = ExpressionConverter.ConvertO(bodyincidentArmId);
            bodypropCount++;
            body["taskTitle"] = ExpressionConverter.ConvertO(bodytaskTitle);
            if (bodytaskDescription != null)
            {
                body["taskDescription"] = ExpressionConverter.ConvertO(bodytaskDescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IncidentTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<IncidentTask> CompleteIncidentTask(Expression<Func<string>> bodytaskArmId)
        {
            var apiCallPath = "/Incidents/CompleteTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["taskArmId"] = ExpressionConverter.ConvertO(bodytaskArmId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IncidentTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<IncidentRelation> CreateIncidentRelation(Expression<Func<string>> bodyincidentArmId, Expression<Func<string>> bodyrelatedResourceId)
        {
            var apiCallPath = "/Incidents/Relation/Create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["incidentArmId"] = ExpressionConverter.ConvertO(bodyincidentArmId);
            bodypropCount++;
            body["relatedResourceId"] = ExpressionConverter.ConvertO(bodyrelatedResourceId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IncidentRelation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<string> DeleteIncidentRelation(Expression<Func<string>> bodyincidentArmId, Expression<Func<string>> bodyrelatedResourceId)
        {
            var apiCallPath = "/Incidents/Relation/Delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["incidentArmId"] = ExpressionConverter.ConvertO(bodyincidentArmId);
            bodypropCount++;
            body["relatedResourceId"] = ExpressionConverter.ConvertO(bodyrelatedResourceId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IWorkflowAction WatchlistDeleteV2(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias)
        {
            var apiCallPath = String.Format("/V2/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<JToken> WatchlistItemsListV2(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias, Expression<Func<string>> skipToken = null)
        {
            var apiCallPath = String.Format("/V2/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}/watchlistItems/", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (skipToken != null)
                callPayload.Queries["skipToken"] = ExpressionConverter.Convert(skipToken);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<string> WatchlistItemsDeleteV2(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias, Expression<Func<string>> watchlistItemId)
        {
            var apiCallPath = String.Format("/V2/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}/watchlistItem/{4}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistItemId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<JToken> WatchlistItemsList(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias)
        {
            var apiCallPath = String.Format("/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}/watchlistItems", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<WatchlistItem> WatchlistItemsUpdate(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias, Expression<Func<string>> watchlistItemId)
        {
            var apiCallPath = String.Format("/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}/watchlistItem/{4}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistItemId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WatchlistItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<string> WatchlistItemsDelete(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias, Expression<Func<string>> watchlistItemId)
        {
            var apiCallPath = String.Format("/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}/watchlistItem/{4}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistItemId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<WatchlistItem> WatchlistItemsGet(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias, Expression<Func<string>> watchlistItemId)
        {
            var apiCallPath = String.Format("/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}/watchlistItem/{4}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistItemId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WatchlistItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<string> WatchlistDelete(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias)
        {
            var apiCallPath = String.Format("/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<Watchlist> WatchlistGet(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias)
        {
            var apiCallPath = String.Format("/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Watchlist>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<Watchlist> WatchlistCreate(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias)
        {
            var apiCallPath = String.Format("/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Watchlist>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<Watchlist> WatchlistLargeCreate(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias)
        {
            var apiCallPath = String.Format("/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}/largeWatchlist", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Watchlist>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<WatchlistItem> WatchlistItemsCreate(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> watchlistAlias)
        {
            var apiCallPath = String.Format("/Watchlists/subscriptions/{0}/resourceGroups/{1}/workspaces/{2}/watchlists/{3}/watchlistItem", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(watchlistAlias, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WatchlistItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<BookmarkList> BookmarksList(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<int>> numberOfBookmarks)
        {
            var apiCallPath = String.Format("/Bookmarks/{0}/resourceGroups/{1}/workspaces/{2}/bookmarksList/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(numberOfBookmarks, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BookmarkList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<Bookmark> BookmarksGet(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = String.Format("/Bookmarks/{0}/resourceGroups/{1}/workspaces/{2}/bookmarks/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(bookmarkId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Bookmark>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<string> BookmarksDelete(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = String.Format("/Bookmarks/{0}/resourceGroups/{1}/workspaces/{2}/bookmarks/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(bookmarkId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<string> AddCommentToIncidentV2(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroup, Expression<Func<string>> workspaceId, Expression<Func<identifierInput>> identifier, Expression<Func<string>> id, Expression<Func<string>> commentspecifyComment)
        {
            var apiCallPath = String.Format("/Comment/{0}/{1}/{2}/{3}/{4}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroup, 1), ExpressionConverter.ConvertWithUrlEncoding(identifier, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var comment = new JObject();
            var commentpropCount = 0;
            commentpropCount++;
            comment["Value"] = ExpressionConverter.ConvertO(commentspecifyComment);
            if (commentpropCount > 0)
            {
                callPayload.Body = comment;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<BatchResponseHost> GetHosts(Expression<Func<string>> body = null)
        {
            var apiCallPath = "/entities/host";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BatchResponseHost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<BatchResponseUrl> GetUrls(Expression<Func<string>> body = null)
        {
            var apiCallPath = "/entities/url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BatchResponseUrl>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<BatchResponseIP> GetIPs(Expression<Func<string>> body = null)
        {
            var apiCallPath = "/entities/ip";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BatchResponseIP>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<BatchResponseFileHash> GetFileHashes(Expression<Func<string>> body = null)
        {
            var apiCallPath = "/entities/filehash";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BatchResponseFileHash>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuresentinel")]
        public IBodyWorkflowAction<BatchResponseDNS> GetDNS(Expression<Func<string>> body = null)
        {
            var apiCallPath = "/entities/dnsresolution";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BatchResponseDNS>(callPayload);
        }
    }

    public class AzuresentinelTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> ASITriggerSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscribe";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback_url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> ASIIncidentTriggerSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/incident-creation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback_url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DynamicEntityTriggerEventNotification> ASIEntityTriggerSubscribe(Expression<Func<string>> entityType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/entity/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback_url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<DynamicEntityTriggerEventNotification>(callPayload, triggerName, recurrence);
        }
    }

    public class BatchResponseAccount
    {
        public Account[] Accounts { get; set; }
    }

    public class Account
    {
        public string Name { get; set; }
        public string NTDomain { get; set; }
        public string DnsDomain { get; set; }
        public string UPNSuffix { get; set; }
        public string Sid { get; set; }
        public string AadTenantId { get; set; }
        public string AadUserId { get; set; }
        public string PUID { get; set; }
        public bool IsDomainJoined { get; set; }
        public string ObjectGuid { get; set; }
    }

    public class OldIncident
    {
        [JsonProperty("properties")]
        public OldIncidentProperties Properties { get; set; }
    }

    public class OldIncidentProperties
    {
        public string Status { get; set; }
        public JToken[] Labels { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EndTimeUtc { get; set; }
        public string StartTimeUtc { get; set; }
        public string LastUpdatedTimeUtc { get; set; }
        public string CaseNumber { get; set; }
        public string CreatedTimeUtc { get; set; }
        public string Severity { get; set; }
        public JToken[] RelatedAlertIds { get; set; }
    }

    public class Incident
    {
        [JsonProperty("id")]
        public string IncidentARMID { get; set; }

        [JsonProperty("name")]
        public string IncidentARMName { get; set; }

        [JsonProperty("properties")]
        public IncidentProperties Properties { get; set; }
    }

    public class IncidentProperties
    {
        [JsonProperty("additionalData")]
        public IncidentAdditionalData AdditionalData { get; set; }

        [JsonProperty("classification")]
        public IncidentPropertiesIncidentClassificationType IncidentClassification { get; set; }

        [JsonProperty("classificationComment")]
        public string IncidentClassificationComment { get; set; }

        [JsonProperty("classificationReason")]
        public IncidentPropertiesIncidentClassificationReasonType IncidentClassificationReason { get; set; }

        [JsonProperty("createdTimeUtc")]
        public string IncidentCreatedTimeUtc { get; set; }

        [JsonProperty("description")]
        public string IncidentDescription { get; set; }

        [JsonProperty("firstActivityTimeUtc")]
        public string IncidentFirstActivityTimeUTC { get; set; }

        [JsonProperty("incidentUrl")]
        public string IncidentURL { get; set; }

        [JsonProperty("providerIncidentId")]
        public string ProviderIncidentId { get; set; }

        [JsonProperty("incidentNumber")]
        public int IncidentSentinelID { get; set; }

        [JsonProperty("lastActivityTimeUtc")]
        public string IncidentLastActivityTimeUTC { get; set; }

        [JsonProperty("severity")]
        public IncidentPropertiesIncidentSeverityType IncidentSeverity { get; set; }

        [JsonProperty("status")]
        public IncidentPropertiesIncidentStatusType IncidentStatus { get; set; }

        [JsonProperty("title")]
        public string IncidentTitle { get; set; }

        [JsonProperty("labels")]
        public IncidentLabel[] IncidentTags { get; set; }

        [JsonProperty("lastModifiedTimeUtc")]
        public string IncidentLastModifiedTimeUTC { get; set; }

        [JsonProperty("owner")]
        public IncidentOwnerInfo Owner { get; set; }

        [JsonProperty("relatedAnalyticRuleIds")]
        public string[] IncidentRelatedAnalyticRuleIds { get; set; }
        public IncidentComment[] Comments { get; set; }
    }

    public class IncidentAdditionalData
    {
        [JsonProperty("alertsCount")]
        public int IncidentAlertsCount { get; set; }

        [JsonProperty("bookmarksCount")]
        public int IncidentBookmarksCount { get; set; }

        [JsonProperty("commentsCount")]
        public int IncidentCommentsCount { get; set; }

        [JsonProperty("alertProductNames")]
        public string[] IncidentAlertProductNames { get; set; }

        [JsonProperty("providerIncidentUrl")]
        public string ProviderIncidentUrl { get; set; }

        [JsonProperty("mergedIncidentNumber")]
        public string MergedIncidentNumber { get; set; }

        [JsonProperty("mergedIncidentUrl")]
        public string MergedIncidentUrl { get; set; }

        [JsonProperty("tactics")]
        public AttackTactic[] IncidentTactics { get; set; }

        [JsonProperty("techniques")]
        public string[] IncidentTechniques { get; set; }
    }

    public enum AttackTactic
    {
        InitialAccess,
        Execution,
        Persistence,
        PrivilegeEscalation,
        DefenseEvasion,
        CredentialAccess,
        Discovery,
        LateralMovement,
        Collection,
        Exfiltration,
        CommandAndControl,
        Impact,
        Reconnaissance,
        ResourceDevelopment,
        ImpairProcessControl,
        InhibitResponseFunction
    }

    public enum IncidentPropertiesIncidentClassificationType
    {
        Undetermined,
        TruePositive,
        BenignPositive,
        FalsePositive
    }

    public enum IncidentPropertiesIncidentClassificationReasonType
    {
        SuspiciousActivity,
        SuspiciousButExpected,
        IncorrectAlertLogic,
        InaccurateData
    }

    public enum IncidentPropertiesIncidentSeverityType
    {
        High,
        Medium,
        Low,
        Informational
    }

    public enum IncidentPropertiesIncidentStatusType
    {
        New,
        Active,
        Closed
    }

    public class IncidentLabel
    {
        [JsonProperty("labelName")]
        public string Name { get; set; }

        [JsonProperty("labelType")]
        public IncidentLabelTypeType Type { get; set; }
    }

    public enum IncidentLabelTypeType
    {
        User,
        System
    }

    public class IncidentOwnerInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class IncidentComment
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class ClientTags
    {
        public string Tag { get; set; }
    }

    public enum bodyownerActionInput
    {
        Assign,
        Unassign
    }

    public enum bodyseverityInput
    {
        Informational,
        Low,
        Medium,
        High
    }

    public enum bodystatusInput
    {
        New,
        Active,
        Closed
    }

    public class IncidentTask
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class IncidentRelation
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class WatchlistItem
    {
        [JsonProperty("id")]
        public string WatchlistItemFullARMID { get; set; }

        [JsonProperty("name")]
        public string WatchlistItemUniqueID { get; set; }

        [JsonProperty("etag")]
        public string WatchlistItemEtag { get; set; }

        [JsonProperty("type")]
        public string WatchlistItemType { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class Watchlist
    {
        [JsonProperty("properties")]
        public WatchlistProperties Properties { get; set; }
    }

    public class WatchlistProperties
    {
        [JsonProperty("watchlistId")]
        public string WatchlistId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("source")]
        public WatchlistPropertiesSourceType Source { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("createdBy")]
        public JToken CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public JToken UpdatedBy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("watchlistType")]
        public string WatchlistType { get; set; }

        [JsonProperty("watchlistAlias")]
        public string WatchlistAlias { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("defaultDuration")]
        public string DefaultDuration { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("numberOfLinesToSkip")]
        public int NumberOfLinesToSkip { get; set; }

        [JsonProperty("rawContent")]
        public string RawContent { get; set; }

        [JsonProperty("itemsSearchKey")]
        public string ItemsSearchKey { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("uploadStatus")]
        public string UploadStatus { get; set; }

        [JsonProperty("watchlistItemsCount")]
        public int WatchlistItemsCount { get; set; }
    }

    public enum WatchlistPropertiesSourceType
    {
        [EnumMember(Value = "Local file")]
        LocalFile,
        [EnumMember(Value = "Remote storage")]
        RemoteStorage
    }

    public class BookmarkList
    {
        [JsonProperty("nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public Bookmark[] Value { get; set; }
    }

    public class Bookmark
    {
        [JsonProperty("properties")]
        public BookmarkProperties Properties { get; set; }
    }

    public class BookmarkProperties
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdBy")]
        public JToken CreatedBy { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("queryResult")]
        public string QueryResult { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedBy")]
        public JToken UpdatedBy { get; set; }

        [JsonProperty("eventTime")]
        public string EventTime { get; set; }

        [JsonProperty("queryStartTime")]
        public string QueryStartTime { get; set; }

        [JsonProperty("queryEndTime")]
        public string QueryEndTime { get; set; }

        [JsonProperty("incidentInfo")]
        public JToken IncidentInfo { get; set; }
    }

    public enum identifierInput
    {
        Incident,
        Alert
    }

    public class BatchResponseHost
    {
        public Host[] Hosts { get; set; }
    }

    public class Host
    {
        public string DnsDomain { get; set; }
        public string NTDomain { get; set; }
        public string HostName { get; set; }
        public string NetBiosName { get; set; }
        public string OMSAgentID { get; set; }
        public string OSFamily { get; set; }
        public string OSVersion { get; set; }
        public bool IsDomainJoined { get; set; }
        public string AzureID { get; set; }
    }

    public class BatchResponseUrl
    {
        public UrlEntity[] URLs { get; set; }
    }

    public class UrlEntity
    {
        public string Url { get; set; }
    }

    public class BatchResponseIP
    {
        public IP[] IPs { get; set; }
    }

    public class IP
    {
        public string Address { get; set; }
    }

    public class BatchResponseFileHash
    {
        public FileHash[] Filehashes { get; set; }
    }

    public class FileHash
    {
        public string Value { get; set; }
        public FileHashAlgorithmType Algorithm { get; set; }
    }

    public enum FileHashAlgorithmType
    {
        Unknown,
        MD5,
        SHA1,
        SHA256,
        SHA256AC
    }

    public class BatchResponseDNS
    {
        public DNS[] Dnsresolutions { get; set; }
    }

    public class DNS
    {
        public string DomainName { get; set; }
    }

    public class DynamicEntityTriggerEventNotification
    {
        [JsonProperty("IncidentArmID")]
        public string IncidentARMIDOptional { get; set; }
        public DynamicEntityTriggerEventNotificationEntityType Entity { get; set; }
    }

    public class DynamicEntityTriggerEventNotificationEntityType
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuresentinel;

    public partial class WorkflowManagedActions
    {
        public AzuresentinelActions Azuresentinel(string connectionId) => new AzuresentinelActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuresentinelTriggers Azuresentinel(string connectionId) => new AzuresentinelTriggers(connectionId);
    }
}