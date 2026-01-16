//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Daffyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DaffyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "daffyip")]
        public IBodyWorkflowAction<ProfileGetResponse> ProfileGet()
        {
            var apiCallPath = "/users/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProfileGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "daffyip")]
        public IBodyWorkflowAction<BalanceGetResponse> BalanceGet()
        {
            var apiCallPath = "/users/me/balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BalanceGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "daffyip")]
        public IBodyWorkflowAction<CausesGetResponseItem[]> CausesGet(Expression<Func<string>> userId, Expression<Func<int>> page = null)
        {
            var apiCallPath = String.Format("/users/{0}/causes", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<CausesGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "daffyip")]
        public IBodyWorkflowAction<ContributionsGetResponse> ContributionsGet(Expression<Func<int>> page = null)
        {
            var apiCallPath = "/contributions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<ContributionsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "daffyip")]
        public IBodyWorkflowAction<DonationsGetResponse> DonationsGet(Expression<Func<string>> userId, Expression<Func<int>> page = null)
        {
            var apiCallPath = String.Format("/users/{0}/donations", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<DonationsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "daffyip")]
        public IBodyWorkflowAction<GiftsGetResponse> GiftsGet(Expression<Func<int>> page = null)
        {
            var apiCallPath = "/gifts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<GiftsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "daffyip")]
        public IBodyWorkflowAction<NonProfitGetResponse> NonProfitGet(Expression<Func<string>> ein)
        {
            var apiCallPath = String.Format("/non_profits/{0}", ExpressionConverter.ConvertWithUrlEncoding(ein, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NonProfitGetResponse>(callPayload);
        }
    }

    public class DaffyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ProfileGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("fund_name")]
        public string FundName { get; set; }

        [JsonProperty("current_fund")]
        public ProfileGetResponseCurrentFundType CurrentFund { get; set; }

        [JsonProperty("follows_user")]
        public bool FollowsUser { get; set; }

        [JsonProperty("follows_viewer")]
        public bool FollowsViewer { get; set; }
    }

    public class ProfileGetResponseCurrentFundType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("causes")]
        public ProfileGetResponseCurrentFundTypeCausesTypeItem[] Causes { get; set; }

        [JsonProperty("users")]
        public ProfileGetResponseCurrentFundTypeUsersTypeItem[] Users { get; set; }
    }

    public class ProfileGetResponseCurrentFundTypeCausesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }

    public class ProfileGetResponseCurrentFundTypeUsersTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class BalanceGetResponse
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("pending_deposit_balance")]
        public double PendingDepositBalance { get; set; }

        [JsonProperty("portfolio_balance")]
        public double PortfolioBalance { get; set; }

        [JsonProperty("available_balance")]
        public double AvailableBalance { get; set; }
    }

    public class CausesGetResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class ContributionsGetResponse
    {
        [JsonProperty("items")]
        public ContributionsGetResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("meta")]
        public ContributionsGetResponseMetaType Meta { get; set; }
    }

    public class ContributionsGetResponseItemsTypeItem
    {
        [JsonProperty("units")]
        public int Units { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("valuation")]
        public int Valuation { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("received_at")]
        public string ReceivedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ContributionsGetResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("last")]
        public int Last { get; set; }
    }

    public class DonationsGetResponse
    {
        [JsonProperty("items")]
        public DonationsGetResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("meta")]
        public DonationsGetResponseMetaType Meta { get; set; }
    }

    public class DonationsGetResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("mailed_at")]
        public string MailedAt { get; set; }

        [JsonProperty("non_profit")]
        public DonationsGetResponseItemsTypeItemNonProfitType NonProfit { get; set; }
    }

    public class DonationsGetResponseItemsTypeItemNonProfitType
    {
        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("public_path")]
        public string PublicPath { get; set; }

        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }

        [JsonProperty("cause_id")]
        public int CauseId { get; set; }
    }

    public class DonationsGetResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("last")]
        public int Last { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
    }

    public class GiftsGetResponse
    {
        [JsonProperty("items")]
        public GiftsGetResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("meta")]
        public GiftsGetResponseMetaType Meta { get; set; }
    }

    public class GiftsGetResponseItemsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("seen")]
        public bool Seen { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("claimed")]
        public bool Claimed { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GiftsGetResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("last")]
        public int Last { get; set; }
    }

    public class NonProfitGetResponse
    {
        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("public_path")]
        public string PublicPath { get; set; }

        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("cause")]
        public NonProfitGetResponseCauseType Cause { get; set; }

        [JsonProperty("causes")]
        public NonProfitGetResponseCausesTypeItem[] Causes { get; set; }
    }

    public class NonProfitGetResponseCauseType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }

    public class NonProfitGetResponseCausesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Daffyip;

    public partial class WorkflowManagedActions
    {
        public DaffyipActions Daffyip(string connectionId) => new DaffyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DaffyipTriggers Daffyip(string connectionId) => new DaffyipTriggers(connectionId);
    }
}