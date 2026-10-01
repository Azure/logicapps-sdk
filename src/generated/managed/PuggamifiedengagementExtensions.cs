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
        public IWorkflowAction CreatePlayer([WorkflowExpression] Func<string> bodyplayeremail = null, [WorkflowExpression] Func<string> bodyplayerprofilefirstName = null, [WorkflowExpression] Func<string> bodyplayerprofilelastName = null, [WorkflowExpression] Func<string> bodyplayerexternalRealm = null, [WorkflowExpression] Func<string> bodyplayerexternalRealmId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    playerObject["email"] = SourceExpressionConverter.ConvertToken(bodyplayeremail);
                    playerObjectpropCount++;
                }

                var profileObject = new JObject();
                var profileObjectpropCount = 0;
                if (bodyplayerprofilefirstName != null)
                {
                    profileObject["first_name"] = SourceExpressionConverter.ConvertToken(bodyplayerprofilefirstName);
                    profileObjectpropCount++;
                }

                if (bodyplayerprofilelastName != null)
                {
                    profileObject["last_name"] = SourceExpressionConverter.ConvertToken(bodyplayerprofilelastName);
                    profileObjectpropCount++;
                }

                if (profileObjectpropCount > 0)
                {
                    playerObject["profile"] = profileObject;
                    playerObjectpropCount++;
                }

                if (bodyplayerexternalRealm != null)
                {
                    playerObject["external_realm"] = SourceExpressionConverter.ConvertToken(bodyplayerexternalRealm);
                    playerObjectpropCount++;
                }

                if (bodyplayerexternalRealmId != null)
                {
                    playerObject["external_realm_id"] = SourceExpressionConverter.ConvertToken(bodyplayerexternalRealmId);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetPlayerAccounts([WorkflowExpression] Func<int> playerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}/currency_accounts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetAccountBalance([WorkflowExpression] Func<int> playerId, [WorkflowExpression] Func<string> accountType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}/currency_accounts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction AddPoints([WorkflowExpression] Func<int> playerId, [WorkflowExpression] Func<string> accountType, [WorkflowExpression] Func<int> amount)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}/currency_accounts/{1}/add_currency/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(amount, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction RemovePoints([WorkflowExpression] Func<int> playerId, [WorkflowExpression] Func<string> accountType, [WorkflowExpression] Func<int> amount)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}/currency_accounts/{1}/remove_currency/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(amount, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetBatch([WorkflowExpression] Func<int> playerId, [WorkflowExpression] Func<int> newBatchSize = null, [WorkflowExpression] Func<int> newBatchMaxPicks = null, [WorkflowExpression] Func<string> newBatchKind = null, [WorkflowExpression] Func<bool> newBatchUseTiers = null, [WorkflowExpression] Func<int> newBatchTtl = null, [WorkflowExpression] Func<string> newBatchMetadata = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (newBatchSize != null)
                    callPayload.Queries["newBatchSize"] = SourceExpressionConverter.ConvertO(newBatchSize);
                if (newBatchMaxPicks != null)
                    callPayload.Queries["newBatchMaxPicks"] = SourceExpressionConverter.ConvertO(newBatchMaxPicks);
                if (newBatchKind != null)
                    callPayload.Queries["newBatchKind"] = SourceExpressionConverter.ConvertO(newBatchKind);
                if (newBatchUseTiers != null)
                    callPayload.Queries["newBatchUseTiers"] = SourceExpressionConverter.ConvertO(newBatchUseTiers);
                if (newBatchTtl != null)
                    callPayload.Queries["newBatchTtl"] = SourceExpressionConverter.ConvertO(newBatchTtl);
                if (newBatchMetadata != null)
                    callPayload.Queries["newBatchMetadata"] = SourceExpressionConverter.ConvertO(newBatchMetadata);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction ListBadges()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/rewards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetBadge([WorkflowExpression] Func<string> rewardRef)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/instances/rewards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rewardRef, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction IssueBadge([WorkflowExpression] Func<int> playerId, [WorkflowExpression] Func<string> rewardRef)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}/instances/rewards/issue_instance_by_ref/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rewardRef, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction ClaimInstance([WorkflowExpression] Func<int> playerId, [WorkflowExpression] Func<string> rewardInstanceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}/instances/rewards/claim_instance_by_id/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rewardInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetBadgesInstances([WorkflowExpression] Func<int> playerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}/instances/rewards", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction GetBadgeInstance([WorkflowExpression] Func<int> playerId, [WorkflowExpression] Func<string> rewardRef)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}/instances/rewards/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rewardRef, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "puggamifiedengagement")]
        public IWorkflowAction AddItemInstance([WorkflowExpression] Func<int> playerId, [WorkflowExpression] Func<string> itemRef)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/players/{0}/add_item_instance_by_ref/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(playerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(itemRef, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/vnd.sno-ge.iapi+json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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