//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Givebutterip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GivebutteripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<CampaignGetResponse> CampaignGet([WorkflowExpression] Func<string> scope = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/campaigns";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (scope != null)
                    callPayload.Queries["scope"] = SourceExpressionConverter.ConvertO(scope);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<CampaignPostResponse> Campaign([WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyendAt = null, [WorkflowExpression] Func<int> bodygoal = null, [WorkflowExpression] Func<string> bodysubtitle = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/campaigns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyendAt != null)
                {
                    body["end_at"] = SourceExpressionConverter.ConvertToken(bodyendAt);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodysubtitle != null)
                {
                    body["subtitle"] = SourceExpressionConverter.ConvertToken(bodysubtitle);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CampaignPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<CampaignGetAResponse> CampaignGetA([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<string> CampaignDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<CampaignPatchResponse> CampaignPatch([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyendAt = null, [WorkflowExpression] Func<string> bodygoal = null, [WorkflowExpression] Func<string> bodysubtitle = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyendAt != null)
                {
                    body["end_at"] = SourceExpressionConverter.ConvertToken(bodyendAt);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodysubtitle != null)
                {
                    body["subtitle"] = SourceExpressionConverter.ConvertToken(bodysubtitle);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CampaignPatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<MemberGetResponse> MemberGet([WorkflowExpression] Func<string> campaignId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MemberGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<MemberGetAResponse> MemberGetA([WorkflowExpression] Func<string> campaignId, [WorkflowExpression] Func<string> memberId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/members/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MemberGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<string> MemberDelete([WorkflowExpression] Func<string> campaignId, [WorkflowExpression] Func<string> memberId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/members/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<TeamGetResponse> TeamGet([WorkflowExpression] Func<string> campaignId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/teams", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TeamGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<TeamGetAResponse> TeamGetA([WorkflowExpression] Func<string> campaignId, [WorkflowExpression] Func<string> teamId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/teams/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TeamGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<ContactGetResponse> ContactGet([WorkflowExpression] Func<string> scope = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (scope != null)
                    callPayload.Queries["scope"] = SourceExpressionConverter.ConvertO(scope);
                return callPayload;
            }

            return new ApiConnectionAction<ContactGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<ContactPostResponse> Contact([WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<bodyemailsInputItem[]> bodyemails = null, [WorkflowExpression] Func<bodyphonesInputItem[]> bodyphones = null, [WorkflowExpression] Func<bodyaddressesInputItem[]> bodyaddresses = null, [WorkflowExpression] Func<string[]> bodytags = null, [WorkflowExpression] Func<string> bodydob = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodytwitterUrl = null, [WorkflowExpression] Func<string> bodylinkedinUrl = null, [WorkflowExpression] Func<string> bodyfacebookUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle_name"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["emails"] = SourceExpressionConverter.ConvertToken(bodyemails);
                    bodypropCount++;
                }

                if (bodyphones != null)
                {
                    body["phones"] = SourceExpressionConverter.ConvertToken(bodyphones);
                    bodypropCount++;
                }

                if (bodyaddresses != null)
                {
                    body["addresses"] = SourceExpressionConverter.ConvertToken(bodyaddresses);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodydob != null)
                {
                    body["dob"] = SourceExpressionConverter.ConvertToken(bodydob);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodytwitterUrl != null)
                {
                    body["twitter_url"] = SourceExpressionConverter.ConvertToken(bodytwitterUrl);
                    bodypropCount++;
                }

                if (bodylinkedinUrl != null)
                {
                    body["linkedin_url"] = SourceExpressionConverter.ConvertToken(bodylinkedinUrl);
                    bodypropCount++;
                }

                if (bodyfacebookUrl != null)
                {
                    body["facebook_url"] = SourceExpressionConverter.ConvertToken(bodyfacebookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<ContactGetAResponse> ContactGetA([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContactGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<ContactPatchResponse> ContactPatch([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodydob = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodytwitterUrl = null, [WorkflowExpression] Func<string> bodylinkedinUrl = null, [WorkflowExpression] Func<string> bodyfacebookUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle_name"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodydob != null)
                {
                    body["dob"] = SourceExpressionConverter.ConvertToken(bodydob);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodytwitterUrl != null)
                {
                    body["twitter_url"] = SourceExpressionConverter.ConvertToken(bodytwitterUrl);
                    bodypropCount++;
                }

                if (bodylinkedinUrl != null)
                {
                    body["linkedin_url"] = SourceExpressionConverter.ConvertToken(bodylinkedinUrl);
                    bodypropCount++;
                }

                if (bodyfacebookUrl != null)
                {
                    body["facebook_url"] = SourceExpressionConverter.ConvertToken(bodyfacebookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactPatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<string> ContactDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<ContactRestoreResponse> ContactRestore([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/{0}/restore", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContactRestoreResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<TicketGetResponse> TicketGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TicketGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<TicketGetAResponse> TicketGetA([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TicketGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<TransactionGetResponse> TransactionGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/transactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TransactionGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<TransactionGetAResponse> TransactionGetA([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/transactions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TransactionGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<PayoutGetResponse> PayoutGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/payouts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PayoutGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<PayoutGetAResponse> PayoutGetA([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/payouts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PayoutGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<PlanGetResponse> PlanGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/plans";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PlanGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<PlanGetAResponse> PlanGetA([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/plans/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PlanGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<FundGetResponse> FundGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/funds";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<FundPostResponse> Fund([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/funds";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<FundGetAResponse> FundGetA([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/funds/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<FundPatchResponse> FundPatch([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/funds/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundPatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "givebutterip")]
        public IBodyWorkflowAction<string> FundDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/funds/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class GivebutteripTriggers([ConnectionName] string connectionId)
    {
    }

    public class CampaignGetResponse
    {
        [JsonProperty("data")]
        public CampaignGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public CampaignGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public CampaignGetResponseMetaType Meta { get; set; }
    }

    public class CampaignGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("donors")]
        public int Donors { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("cover")]
        public CampaignGetResponseDataTypeItemCoverType Cover { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("event")]
        public CampaignGetResponseDataTypeItemEventType Event { get; set; }
    }

    public class CampaignGetResponseDataTypeItemCoverType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class CampaignGetResponseDataTypeItemEventType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location_name")]
        public string LocationName { get; set; }

        [JsonProperty("address_formatted")]
        public string AddressFormatted { get; set; }

        [JsonProperty("google_place_id")]
        public string GooglePlaceId { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("tickets_required")]
        public bool TicketsRequired { get; set; }

        [JsonProperty("livestream")]
        public CampaignGetResponseDataTypeItemEventTypeLivestreamType Livestream { get; set; }

        [JsonProperty("livestream_start_at")]
        public string LivestreamStartAt { get; set; }

        [JsonProperty("livestream_end_at")]
        public string LivestreamEndAt { get; set; }
    }

    public class CampaignGetResponseDataTypeItemEventTypeLivestreamType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("scheduled")]
        public bool Scheduled { get; set; }
    }

    public class CampaignGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class CampaignGetResponseMetaType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public CampaignGetResponseMetaTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("unfiltered_total")]
        public int UnfilteredTotal { get; set; }
    }

    public class CampaignGetResponseMetaTypeLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class CampaignPostResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("donors")]
        public int Donors { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("cover")]
        public CampaignPostResponseCoverType Cover { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CampaignPostResponseCoverType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class CampaignGetAResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("donors")]
        public int Donors { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("cover")]
        public CampaignGetAResponseCoverType Cover { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("event")]
        public CampaignGetAResponseEventType Event { get; set; }
    }

    public class CampaignGetAResponseCoverType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class CampaignGetAResponseEventType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location_name")]
        public string LocationName { get; set; }

        [JsonProperty("address_formatted")]
        public string AddressFormatted { get; set; }

        [JsonProperty("google_place_id")]
        public string GooglePlaceId { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("tickets_required")]
        public bool TicketsRequired { get; set; }

        [JsonProperty("livestream")]
        public CampaignGetAResponseEventTypeLivestreamType Livestream { get; set; }

        [JsonProperty("livestream_start_at")]
        public string LivestreamStartAt { get; set; }

        [JsonProperty("livestream_end_at")]
        public string LivestreamEndAt { get; set; }
    }

    public class CampaignGetAResponseEventTypeLivestreamType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("scheduled")]
        public bool Scheduled { get; set; }
    }

    public class CampaignPatchResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("donors")]
        public int Donors { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("cover")]
        public CampaignPatchResponseCoverType Cover { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CampaignPatchResponseCoverType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class MemberGetResponse
    {
        [JsonProperty("data")]
        public MemberGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public MemberGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public MemberGetResponseMetaType Meta { get; set; }
    }

    public class MemberGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("donors")]
        public int Donors { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MemberGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class MemberGetResponseMetaType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public MemberGetResponseMetaTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class MemberGetResponseMetaTypeLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class MemberGetAResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("donors")]
        public int Donors { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class TeamGetResponse
    {
        [JsonProperty("data")]
        public TeamGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public TeamGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public TeamGetResponseMetaType Meta { get; set; }
    }

    public class TeamGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("supporters")]
        public int Supporters { get; set; }

        [JsonProperty("members")]
        public int Members { get; set; }
    }

    public class TeamGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class TeamGetResponseMetaType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public TeamGetResponseMetaTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class TeamGetResponseMetaTypeLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class TeamGetAResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("supporters")]
        public int Supporters { get; set; }

        [JsonProperty("members")]
        public int Members { get; set; }
    }

    public class ContactGetResponse
    {
        [JsonProperty("data")]
        public ContactGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public ContactGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public ContactGetResponseMetaType Meta { get; set; }
    }

    public class ContactGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("emails")]
        public ContactGetResponseDataTypeItemEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public ContactGetResponseDataTypeItemPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("primary_email")]
        public string PrimaryEmail { get; set; }

        [JsonProperty("primary_phone")]
        public string PrimaryPhone { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("addresses")]
        public ContactGetResponseDataTypeItemAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("primary_address")]
        public ContactGetResponseDataTypeItemPrimaryAddressType PrimaryAddress { get; set; }

        [JsonProperty("stats")]
        public ContactGetResponseDataTypeItemStatsType Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("custom_fields")]
        public JToken[] CustomFields { get; set; }

        [JsonProperty("archived_at")]
        public string ArchivedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactGetResponseDataTypeItemEmailsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactGetResponseDataTypeItemPhonesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactGetResponseDataTypeItemAddressesTypeItem
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactGetResponseDataTypeItemPrimaryAddressType
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactGetResponseDataTypeItemStatsType
    {
        [JsonProperty("recurring_contributions")]
        public int RecurringContributions { get; set; }

        [JsonProperty("total_contributions")]
        public int TotalContributions { get; set; }
    }

    public class ContactGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class ContactGetResponseMetaType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public ContactGetResponseMetaTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ContactGetResponseMetaTypeLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class ContactPostResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("emails")]
        public ContactPostResponseEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public ContactPostResponsePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("primary_email")]
        public string PrimaryEmail { get; set; }

        [JsonProperty("primary_phone")]
        public string PrimaryPhone { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("addresses")]
        public ContactPostResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("primary_address")]
        public ContactPostResponsePrimaryAddressType PrimaryAddress { get; set; }

        [JsonProperty("stats")]
        public ContactPostResponseStatsType Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("custom_fields")]
        public JToken[] CustomFields { get; set; }

        [JsonProperty("archived_at")]
        public string ArchivedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactPostResponseEmailsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactPostResponsePhonesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactPostResponseAddressesTypeItem
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactPostResponsePrimaryAddressType
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactPostResponseStatsType
    {
        [JsonProperty("recurring_contributions")]
        public int RecurringContributions { get; set; }

        [JsonProperty("total_contributions")]
        public int TotalContributions { get; set; }
    }

    public class bodyemailsInputItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class bodyphonesInputItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class bodyaddressesInputItem
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ContactGetAResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("emails")]
        public ContactGetAResponseEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public ContactGetAResponsePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("primary_email")]
        public string PrimaryEmail { get; set; }

        [JsonProperty("primary_phone")]
        public string PrimaryPhone { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("addresses")]
        public ContactGetAResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("primary_address")]
        public ContactGetAResponsePrimaryAddressType PrimaryAddress { get; set; }

        [JsonProperty("stats")]
        public ContactGetAResponseStatsType Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("custom_fields")]
        public JToken[] CustomFields { get; set; }

        [JsonProperty("archived_at")]
        public string ArchivedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactGetAResponseEmailsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactGetAResponsePhonesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactGetAResponseAddressesTypeItem
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactGetAResponsePrimaryAddressType
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactGetAResponseStatsType
    {
        [JsonProperty("recurring_contributions")]
        public int RecurringContributions { get; set; }

        [JsonProperty("total_contributions")]
        public int TotalContributions { get; set; }
    }

    public class ContactPatchResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("emails")]
        public ContactPatchResponseEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public ContactPatchResponsePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("primary_email")]
        public string PrimaryEmail { get; set; }

        [JsonProperty("primary_phone")]
        public string PrimaryPhone { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("addresses")]
        public ContactPatchResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("primary_address")]
        public ContactPatchResponsePrimaryAddressType PrimaryAddress { get; set; }

        [JsonProperty("stats")]
        public ContactPatchResponseStatsType Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("custom_fields")]
        public JToken[] CustomFields { get; set; }

        [JsonProperty("archived_at")]
        public string ArchivedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactPatchResponseEmailsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactPatchResponsePhonesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactPatchResponseAddressesTypeItem
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactPatchResponsePrimaryAddressType
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactPatchResponseStatsType
    {
        [JsonProperty("recurring_contributions")]
        public int RecurringContributions { get; set; }

        [JsonProperty("total_contributions")]
        public int TotalContributions { get; set; }
    }

    public class ContactRestoreResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("emails")]
        public ContactRestoreResponseEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public ContactRestoreResponsePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("primary_email")]
        public string PrimaryEmail { get; set; }

        [JsonProperty("primary_phone")]
        public string PrimaryPhone { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("addresses")]
        public ContactRestoreResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("primary_address")]
        public ContactRestoreResponsePrimaryAddressType PrimaryAddress { get; set; }

        [JsonProperty("stats")]
        public ContactRestoreResponseStatsType Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("custom_fields")]
        public JToken[] CustomFields { get; set; }

        [JsonProperty("archived_at")]
        public string ArchivedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactRestoreResponseEmailsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactRestoreResponsePhonesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ContactRestoreResponseAddressesTypeItem
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactRestoreResponsePrimaryAddressType
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_primary")]
        public int IsPrimary { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ContactRestoreResponseStatsType
    {
        [JsonProperty("recurring_contributions")]
        public int RecurringContributions { get; set; }

        [JsonProperty("total_contributions")]
        public int TotalContributions { get; set; }
    }

    public class TicketGetResponse
    {
        [JsonProperty("data")]
        public TicketGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public TicketGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public TicketGetResponseMetaType Meta { get; set; }
    }

    public class TicketGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_suffix")]
        public string IdSuffix { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("pdf")]
        public string Pdf { get; set; }

        [JsonProperty("arrived_at")]
        public string ArrivedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TicketGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class TicketGetResponseMetaType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public TicketGetResponseMetaTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class TicketGetResponseMetaTypeLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class TicketGetAResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_suffix")]
        public string IdSuffix { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("pdf")]
        public string Pdf { get; set; }

        [JsonProperty("arrived_at")]
        public string ArrivedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TransactionGetResponse
    {
        [JsonProperty("data")]
        public TransactionGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public TransactionGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public TransactionGetResponseMetaType Meta { get; set; }
    }

    public class TransactionGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("campaign_id")]
        public int CampaignId { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public TransactionGetResponseDataTypeItemAddressType Address { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("fee")]
        public double Fee { get; set; }

        [JsonProperty("fee_covered")]
        public double FeeCovered { get; set; }

        [JsonProperty("donated")]
        public int Donated { get; set; }

        [JsonProperty("payout")]
        public int Payout { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("giving_space")]
        public TransactionGetResponseDataTypeItemGivingSpaceType GivingSpace { get; set; }

        [JsonProperty("transactions")]
        public TransactionGetResponseDataTypeItemTransactionsTypeItem[] Transactions { get; set; }
    }

    public class TransactionGetResponseDataTypeItemAddressType
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class TransactionGetResponseDataTypeItemGivingSpaceType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TransactionGetResponseDataTypeItemTransactionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("fee")]
        public double Fee { get; set; }

        [JsonProperty("fee_covered")]
        public double FeeCovered { get; set; }

        [JsonProperty("donated")]
        public int Donated { get; set; }

        [JsonProperty("payout")]
        public int Payout { get; set; }

        [JsonProperty("captured")]
        public bool Captured { get; set; }

        [JsonProperty("captured_at")]
        public string CapturedAt { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("line_items")]
        public TransactionGetResponseDataTypeItemTransactionsTypeItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public class TransactionGetResponseDataTypeItemTransactionsTypeItemLineItemsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class TransactionGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class TransactionGetResponseMetaType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public TransactionGetResponseMetaTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class TransactionGetResponseMetaTypeLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class TransactionGetAResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("campaign_id")]
        public int CampaignId { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public TransactionGetAResponseAddressType Address { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("fee")]
        public double Fee { get; set; }

        [JsonProperty("fee_covered")]
        public double FeeCovered { get; set; }

        [JsonProperty("donated")]
        public int Donated { get; set; }

        [JsonProperty("payout")]
        public int Payout { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("giving_space")]
        public TransactionGetAResponseGivingSpaceType GivingSpace { get; set; }

        [JsonProperty("transactions")]
        public TransactionGetAResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class TransactionGetAResponseAddressType
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class TransactionGetAResponseGivingSpaceType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TransactionGetAResponseTransactionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("fee")]
        public double Fee { get; set; }

        [JsonProperty("fee_covered")]
        public double FeeCovered { get; set; }

        [JsonProperty("donated")]
        public int Donated { get; set; }

        [JsonProperty("payout")]
        public int Payout { get; set; }

        [JsonProperty("captured")]
        public bool Captured { get; set; }

        [JsonProperty("captured_at")]
        public string CapturedAt { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("line_items")]
        public TransactionGetAResponseTransactionsTypeItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public class TransactionGetAResponseTransactionsTypeItemLineItemsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class PayoutGetResponse
    {
        [JsonProperty("data")]
        public PayoutGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public PayoutGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public PayoutGetResponseMetaType Meta { get; set; }
    }

    public class PayoutGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("campaign_id")]
        public int CampaignId { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("fee")]
        public int Fee { get; set; }

        [JsonProperty("tip")]
        public int Tip { get; set; }

        [JsonProperty("payout")]
        public int Payout { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("address")]
        public PayoutGetResponseDataTypeItemAddressType Address { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class PayoutGetResponseDataTypeItemAddressType
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class PayoutGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class PayoutGetResponseMetaType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public PayoutGetResponseMetaTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class PayoutGetResponseMetaTypeLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class PayoutGetAResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("campaign_id")]
        public int CampaignId { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("fee")]
        public int Fee { get; set; }

        [JsonProperty("tip")]
        public int Tip { get; set; }

        [JsonProperty("payout")]
        public int Payout { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("address")]
        public PayoutGetAResponseAddressType Address { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class PayoutGetAResponseAddressType
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class PlanGetResponse
    {
        [JsonProperty("data")]
        public PlanGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public PlanGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public PlanGetResponseMetaType Meta { get; set; }
    }

    public class PlanGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("fee_covered")]
        public double FeeCovered { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("next_bill_date")]
        public string NextBillDate { get; set; }
    }

    public class PlanGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class PlanGetResponseMetaType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public PlanGetResponseMetaTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class PlanGetResponseMetaTypeLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class PlanGetAResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("fee_covered")]
        public double FeeCovered { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("next_bill_date")]
        public string NextBillDate { get; set; }
    }

    public class FundGetResponse
    {
        [JsonProperty("data")]
        public FundGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public FundGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public FundGetResponseMetaType Meta { get; set; }
    }

    public class FundGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("raised")]
        public double Raised { get; set; }

        [JsonProperty("supporters")]
        public int Supporters { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class FundGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class FundGetResponseMetaType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public FundGetResponseMetaTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class FundGetResponseMetaTypeLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class FundPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("supporters")]
        public int Supporters { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class FundGetAResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("raised")]
        public double Raised { get; set; }

        [JsonProperty("supporters")]
        public int Supporters { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class FundPatchResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("raised")]
        public int Raised { get; set; }

        [JsonProperty("supporters")]
        public int Supporters { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Givebutterip;

    public partial class WorkflowManagedActions
    {
        public GivebutteripActions Givebutterip(string connectionId) => new GivebutteripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GivebutteripTriggers Givebutterip(string connectionId) => new GivebutteripTriggers(connectionId);
    }
}