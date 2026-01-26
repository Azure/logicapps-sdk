//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Puggamifiedengagement
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PuggamifiedengagementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction CreatePlayer(Expression<Func<string>> bodyplayeremail = null, Expression<Func<string>> bodyplayerprofilefirstName = null, Expression<Func<string>> bodyplayerprofilelastName = null, Expression<Func<string>> bodyplayerexternalRealm = null, Expression<Func<string>> bodyplayerexternalRealmId = null)
        {
            var apiCallPath = "/api/players/create_player";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            var body = new JObject();
            var bodypropCount = 0;
            var playerObject = new JObject();
            var playerObjectpropCount = 0;
            if (bodyplayeremail != null)
            {
                playerObject["email"] = ExpressionConverter.ConvertO(bodyplayeremail);
                playerObjectpropCount++;
            }

            var profileObject = new JObject();
            var profileObjectpropCount = 0;
            if (bodyplayerprofilefirstName != null)
            {
                profileObject["first_name"] = ExpressionConverter.ConvertO(bodyplayerprofilefirstName);
                profileObjectpropCount++;
            }

            if (bodyplayerprofilelastName != null)
            {
                profileObject["last_name"] = ExpressionConverter.ConvertO(bodyplayerprofilelastName);
                profileObjectpropCount++;
            }

            if (profileObjectpropCount > 0)
            {
                playerObject["profile"] = profileObject;
                playerObjectpropCount++;
            }

            if (bodyplayerexternalRealm != null)
            {
                playerObject["external_realm"] = ExpressionConverter.ConvertO(bodyplayerexternalRealm);
                playerObjectpropCount++;
            }

            if (bodyplayerexternalRealmId != null)
            {
                playerObject["external_realm_id"] = ExpressionConverter.ConvertO(bodyplayerexternalRealmId);
                playerObjectpropCount++;
            }

            if (playerObjectpropCount > 0)
            {
                body["player"] = playerObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetPlayerAccounts(Expression<Func<int>> playerId)
        {
            var apiCallPath = String.Format("/api/players/{0}/currency_accounts", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetAccountBalance(Expression<Func<int>> playerId, Expression<Func<string>> accountType)
        {
            var apiCallPath = String.Format("/api/players/{0}/currency_accounts/{1}", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1), ExpressionConverter.ConvertWithUrlEncoding(accountType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction AddPoints(Expression<Func<int>> playerId, Expression<Func<string>> accountType, Expression<Func<int>> amount)
        {
            var apiCallPath = String.Format("/api/players/{0}/currency_accounts/{1}/add_currency/{2}", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1), ExpressionConverter.ConvertWithUrlEncoding(accountType, 1), ExpressionConverter.ConvertWithUrlEncoding(amount, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction RemovePoints(Expression<Func<int>> playerId, Expression<Func<string>> accountType, Expression<Func<int>> amount)
        {
            var apiCallPath = String.Format("/api/players/{0}/currency_accounts/{1}/remove_currency/{2}", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1), ExpressionConverter.ConvertWithUrlEncoding(accountType, 1), ExpressionConverter.ConvertWithUrlEncoding(amount, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetBatch(Expression<Func<int>> playerId, Expression<Func<int>> newBatchSize = null, Expression<Func<int>> newBatchMaxPicks = null, Expression<Func<string>> newBatchKind = null, Expression<Func<bool>> newBatchUseTiers = null, Expression<Func<int>> newBatchTtl = null, Expression<Func<string>> newBatchMetadata = null)
        {
            var apiCallPath = String.Format("/api/players/{0}", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (newBatchSize != null)
                callPayload.Queries["newBatchSize"] = ExpressionConverter.Convert(newBatchSize);
            if (newBatchMaxPicks != null)
                callPayload.Queries["newBatchMaxPicks"] = ExpressionConverter.Convert(newBatchMaxPicks);
            if (newBatchKind != null)
                callPayload.Queries["newBatchKind"] = ExpressionConverter.Convert(newBatchKind);
            if (newBatchUseTiers != null)
                callPayload.Queries["newBatchUseTiers"] = ExpressionConverter.Convert(newBatchUseTiers);
            if (newBatchTtl != null)
                callPayload.Queries["newBatchTtl"] = ExpressionConverter.Convert(newBatchTtl);
            if (newBatchMetadata != null)
                callPayload.Queries["newBatchMetadata"] = ExpressionConverter.Convert(newBatchMetadata);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction ListBadges()
        {
            var apiCallPath = "/api/rewards";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetBadge(Expression<Func<string>> rewardRef)
        {
            var apiCallPath = String.Format("/api/instances/rewards/{0}", ExpressionConverter.ConvertWithUrlEncoding(rewardRef, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction IssueBadge(Expression<Func<int>> playerId, Expression<Func<string>> rewardRef)
        {
            var apiCallPath = String.Format("/api/players/{0}/instances/rewards/issue_instance_by_ref/{1}", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1), ExpressionConverter.ConvertWithUrlEncoding(rewardRef, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction ClaimInstance(Expression<Func<int>> playerId, Expression<Func<string>> rewardInstanceId)
        {
            var apiCallPath = String.Format("/api/players/{0}/instances/rewards/claim_instance_by_id/{1}", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1), ExpressionConverter.ConvertWithUrlEncoding(rewardInstanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetBadgesInstances(Expression<Func<int>> playerId)
        {
            var apiCallPath = String.Format("/api/players/{0}/instances/rewards", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetBadgeInstance(Expression<Func<int>> playerId, Expression<Func<string>> rewardRef)
        {
            var apiCallPath = String.Format("/api/players/{0}/instances/rewards/{1}", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1), ExpressionConverter.ConvertWithUrlEncoding(rewardRef, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction AddItemInstance(Expression<Func<int>> playerId, Expression<Func<string>> itemRef)
        {
            var apiCallPath = String.Format("/api/players/{0}/add_item_instance_by_ref/{1}", ExpressionConverter.ConvertWithUrlEncoding(playerId, 1), ExpressionConverter.ConvertWithUrlEncoding(itemRef, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
            return new ApiConnectionAction(callPayload);
        }
    }

    public class PuggamifiedengagementTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Puggamifiedengagement;

    public partial class WorkflowManagedActions
    {
        public PuggamifiedengagementActions Puggamifiedengagement(string connectionId) => new PuggamifiedengagementActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PuggamifiedengagementTriggers Puggamifiedengagement(string connectionId) => new PuggamifiedengagementTriggers(connectionId);
    }
}