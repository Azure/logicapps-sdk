//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Waaila
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WaailaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waaila")]
        public IBodyWorkflowAction<GetDepotsResponseItem[], ApiConnectionActionConfiguration> GetDepots(Expression<Func<string>> wauth)
        {
            var __workflow_wauth = WorkflowExpression.Compile(wauth, nameof(wauth), required: true);
            return new DeferredBodyAction<GetDepotsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/depots";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Wauth"] = ExpressionConverter.Convert(__workflow_wauth);
                return new ApiConnectionAction<GetDepotsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waaila")]
        public IBodyWorkflowAction<GetTokenResponse, ApiConnectionActionConfiguration> GetToken(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/auth/exchange-api-code";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTokenResponse>(callPayload);
            });
        }
    }

    public class WaailaTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDepotsResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("testsuites")]
        public GetDepotsResponseItemTestsuitesTypeItem[] Testsuites { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }
    }

    public class GetDepotsResponseItemTestsuitesTypeItem
    {
        [JsonProperty("customName")]
        public string CustomName { get; set; }

        [JsonProperty("results")]
        public GetDepotsResponseItemTestsuitesTypeItemResultsTypeItem[] Results { get; set; }

        [JsonProperty("datasource")]
        public GetDepotsResponseItemTestsuitesTypeItemDatasourceType Datasource { get; set; }

        [JsonProperty("datasourceId")]
        public string DatasourceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tests")]
        public string Tests { get; set; }

        [JsonProperty("providerCode")]
        public string ProviderCode { get; set; }

        [JsonProperty("testsCount")]
        public int TestsCount { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("taglist")]
        public JToken[] Taglist { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }
    }

    public class GetDepotsResponseItemTestsuitesTypeItemResultsTypeItem
    {
        [JsonProperty("maxScore")]
        public int MaxScore { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("testedAt")]
        public string TestedAt { get; set; }

        [JsonProperty("testsError")]
        public int TestsError { get; set; }

        [JsonProperty("testsFailed")]
        public int TestsFailed { get; set; }

        [JsonProperty("testsPassed")]
        public int TestsPassed { get; set; }

        [JsonProperty("testsInfo")]
        public int TestsInfo { get; set; }

        [JsonProperty("testsTotal")]
        public int TestsTotal { get; set; }

        [JsonProperty("testsUnresolved")]
        public int TestsUnresolved { get; set; }

        [JsonProperty("testsWarning")]
        public int TestsWarning { get; set; }

        [JsonProperty("execType")]
        public string ExecType { get; set; }

        [JsonProperty("execBatch")]
        public string ExecBatch { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }
    }

    public class GetDepotsResponseItemTestsuitesTypeItemDatasourceType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("providerCode")]
        public string ProviderCode { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("account")]
        public GetDepotsResponseItemTestsuitesTypeItemDatasourceTypeAccountType Account { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }
    }

    public class GetDepotsResponseItemTestsuitesTypeItemDatasourceTypeAccountType
    {
        [JsonProperty("authentication")]
        public GetDepotsResponseItemTestsuitesTypeItemDatasourceTypeAccountTypeAuthenticationType Authentication { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("authorizedAt")]
        public string AuthorizedAt { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }
    }

    public class GetDepotsResponseItemTestsuitesTypeItemDatasourceTypeAccountTypeAuthenticationType
    {
        [JsonProperty("googleId")]
        public string GoogleId { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("accessTokenExpirationDate")]
        public string AccessTokenExpirationDate { get; set; }

        [JsonProperty("headers")]
        public GetDepotsResponseItemTestsuitesTypeItemDatasourceTypeAccountTypeAuthenticationTypeHeadersType Headers { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("authenticationType")]
        public string AuthenticationType { get; set; }

        [JsonProperty("scopes")]
        public JToken[] Scopes { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }

    public class GetDepotsResponseItemTestsuitesTypeItemDatasourceTypeAccountTypeAuthenticationTypeHeadersType
    {
        public string Authorization { get; set; }

        [JsonProperty("x-api-key")]
        public string XApiKey { get; set; }
    }

    public class GetTokenResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(string code, string email)
        {
            this.Code = code;
            this.Email = email;
        }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Waaila;

    public partial class WorkflowManagedActions
    {
        public WaailaActions Waaila(string connectionId) => new WaailaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WaailaTriggers Waaila(string connectionId) => new WaailaTriggers(connectionId);
    }
}