//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Puggamifiedengagement
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PuggamifiedengagementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreatePlayer(Expression<Func<string>> bodyplayeremail = null, Expression<Func<string>> bodyplayerprofilefirstName = null, Expression<Func<string>> bodyplayerprofilelastName = null, Expression<Func<string>> bodyplayerexternalRealm = null, Expression<Func<string>> bodyplayerexternalRealmId = null)
        {
            var __workflow_bodyplayeremail = WorkflowExpression.Compile(bodyplayeremail, nameof(bodyplayeremail), required: false);
            var __workflow_bodyplayerprofilefirstName = WorkflowExpression.Compile(bodyplayerprofilefirstName, nameof(bodyplayerprofilefirstName), required: false);
            var __workflow_bodyplayerprofilelastName = WorkflowExpression.Compile(bodyplayerprofilelastName, nameof(bodyplayerprofilelastName), required: false);
            var __workflow_bodyplayerexternalRealm = WorkflowExpression.Compile(bodyplayerexternalRealm, nameof(bodyplayerexternalRealm), required: false);
            var __workflow_bodyplayerexternalRealmId = WorkflowExpression.Compile(bodyplayerexternalRealmId, nameof(bodyplayerexternalRealmId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyplayeremail != null)
                {
                    playerObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyplayeremail);
                    playerObjectpropCount++;
                }

                var profileObject = new JObject();
                var profileObjectpropCount = 0;
                if (__workflow_bodyplayerprofilefirstName != null)
                {
                    profileObject["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyplayerprofilefirstName);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyplayerprofilelastName != null)
                {
                    profileObject["last_name"] = ExpressionConverter.ConvertO(__workflow_bodyplayerprofilelastName);
                    profileObjectpropCount++;
                }

                if (profileObjectpropCount > 0)
                {
                    playerObject["profile"] = profileObject;
                    playerObjectpropCount++;
                }

                if (__workflow_bodyplayerexternalRealm != null)
                {
                    playerObject["external_realm"] = ExpressionConverter.ConvertO(__workflow_bodyplayerexternalRealm);
                    playerObjectpropCount++;
                }

                if (__workflow_bodyplayerexternalRealmId != null)
                {
                    playerObject["external_realm_id"] = ExpressionConverter.ConvertO(__workflow_bodyplayerexternalRealmId);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetPlayerAccounts(Expression<Func<int>> playerId)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}/currency_accounts", __workflow_playerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetAccountBalance(Expression<Func<int>> playerId, Expression<Func<string>> accountType)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            var __workflow_accountType = WorkflowExpression.Compile(accountType, nameof(accountType), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}/currency_accounts/{1}", __workflow_playerId.WithUrlEncoding(1), __workflow_accountType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddPoints(Expression<Func<int>> playerId, Expression<Func<string>> accountType, Expression<Func<int>> amount)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            var __workflow_accountType = WorkflowExpression.Compile(accountType, nameof(accountType), required: true);
            var __workflow_amount = WorkflowExpression.Compile(amount, nameof(amount), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}/currency_accounts/{1}/add_currency/{2}", __workflow_playerId.WithUrlEncoding(1), __workflow_accountType.WithUrlEncoding(1), __workflow_amount.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemovePoints(Expression<Func<int>> playerId, Expression<Func<string>> accountType, Expression<Func<int>> amount)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            var __workflow_accountType = WorkflowExpression.Compile(accountType, nameof(accountType), required: true);
            var __workflow_amount = WorkflowExpression.Compile(amount, nameof(amount), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}/currency_accounts/{1}/remove_currency/{2}", __workflow_playerId.WithUrlEncoding(1), __workflow_accountType.WithUrlEncoding(1), __workflow_amount.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetBatch(Expression<Func<int>> playerId, Expression<Func<int>> newBatchSize = null, Expression<Func<int>> newBatchMaxPicks = null, Expression<Func<string>> newBatchKind = null, Expression<Func<bool>> newBatchUseTiers = null, Expression<Func<int>> newBatchTtl = null, Expression<Func<string>> newBatchMetadata = null)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            var __workflow_newBatchSize = WorkflowExpression.Compile(newBatchSize, nameof(newBatchSize), required: false);
            var __workflow_newBatchMaxPicks = WorkflowExpression.Compile(newBatchMaxPicks, nameof(newBatchMaxPicks), required: false);
            var __workflow_newBatchKind = WorkflowExpression.Compile(newBatchKind, nameof(newBatchKind), required: false);
            var __workflow_newBatchUseTiers = WorkflowExpression.Compile(newBatchUseTiers, nameof(newBatchUseTiers), required: false);
            var __workflow_newBatchTtl = WorkflowExpression.Compile(newBatchTtl, nameof(newBatchTtl), required: false);
            var __workflow_newBatchMetadata = WorkflowExpression.Compile(newBatchMetadata, nameof(newBatchMetadata), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}", __workflow_playerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_newBatchSize != null)
                    callPayload.Queries["newBatchSize"] = ExpressionConverter.Convert(__workflow_newBatchSize);
                if (__workflow_newBatchMaxPicks != null)
                    callPayload.Queries["newBatchMaxPicks"] = ExpressionConverter.Convert(__workflow_newBatchMaxPicks);
                if (__workflow_newBatchKind != null)
                    callPayload.Queries["newBatchKind"] = ExpressionConverter.Convert(__workflow_newBatchKind);
                if (__workflow_newBatchUseTiers != null)
                    callPayload.Queries["newBatchUseTiers"] = ExpressionConverter.Convert(__workflow_newBatchUseTiers);
                if (__workflow_newBatchTtl != null)
                    callPayload.Queries["newBatchTtl"] = ExpressionConverter.Convert(__workflow_newBatchTtl);
                if (__workflow_newBatchMetadata != null)
                    callPayload.Queries["newBatchMetadata"] = ExpressionConverter.Convert(__workflow_newBatchMetadata);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ListBadges()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/rewards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetBadge(Expression<Func<string>> rewardRef)
        {
            var __workflow_rewardRef = WorkflowExpression.Compile(rewardRef, nameof(rewardRef), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/instances/rewards/{0}", __workflow_rewardRef.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IssueBadge(Expression<Func<int>> playerId, Expression<Func<string>> rewardRef)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            var __workflow_rewardRef = WorkflowExpression.Compile(rewardRef, nameof(rewardRef), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}/instances/rewards/issue_instance_by_ref/{1}", __workflow_playerId.WithUrlEncoding(1), __workflow_rewardRef.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ClaimInstance(Expression<Func<int>> playerId, Expression<Func<string>> rewardInstanceId)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            var __workflow_rewardInstanceId = WorkflowExpression.Compile(rewardInstanceId, nameof(rewardInstanceId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}/instances/rewards/claim_instance_by_id/{1}", __workflow_playerId.WithUrlEncoding(1), __workflow_rewardInstanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetBadgesInstances(Expression<Func<int>> playerId)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}/instances/rewards", __workflow_playerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetBadgeInstance(Expression<Func<int>> playerId, Expression<Func<string>> rewardRef)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            var __workflow_rewardRef = WorkflowExpression.Compile(rewardRef, nameof(rewardRef), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}/instances/rewards/{1}", __workflow_playerId.WithUrlEncoding(1), __workflow_rewardRef.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddItemInstance(Expression<Func<int>> playerId, Expression<Func<string>> itemRef)
        {
            var __workflow_playerId = WorkflowExpression.Compile(playerId, nameof(playerId), required: true);
            var __workflow_itemRef = WorkflowExpression.Compile(itemRef, nameof(itemRef), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/players/{0}/add_item_instance_by_ref/{1}", __workflow_playerId.WithUrlEncoding(1), __workflow_itemRef.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return new ApiConnectionAction(callPayload);
            });
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