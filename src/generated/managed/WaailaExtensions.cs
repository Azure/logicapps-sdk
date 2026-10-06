//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Waaila
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WaailaActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waaila")]
        [WorkflowExpressionFactory(nameof(__BuildGetDepots))]
        public IBodyWorkflowAction<GetDepotsResponseItem[]> GetDepots([WorkflowExpression] Func<string> wauth)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waaila")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDepotsResponseItem[]> __BuildGetDepots(WorkflowExpression<string> wauth)
        {
            WorkflowExpression.Validate(wauth, nameof(wauth), required: true);
            return new DeferredBodyAction<GetDepotsResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/depots";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Wauth"] = ExpressionConverter.Convert(wauth);
                return new ApiConnectionAction<GetDepotsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waaila")]
        [WorkflowExpressionFactory(nameof(__BuildGetTestsuite))]
        public IBodyWorkflowAction<GetTestsuiteResponse> GetTestsuite([WorkflowExpression] Func<string> depot, [WorkflowExpression] Func<string> testsuite, [WorkflowExpression] Func<string> wauth)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waaila")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTestsuiteResponse> __BuildGetTestsuite(WorkflowExpression<string> depot, WorkflowExpression<string> testsuite, WorkflowExpression<string> wauth)
        {
            WorkflowExpression.Validate(depot, nameof(depot), required: true);
            WorkflowExpression.Validate(testsuite, nameof(testsuite), required: true);
            WorkflowExpression.Validate(wauth, nameof(wauth), required: true);
            return new DeferredBodyAction<GetTestsuiteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/depot/{0}/testsuite/{1}", ExpressionConverter.ConvertWithUrlEncoding(depot, 1), ExpressionConverter.ConvertWithUrlEncoding(testsuite, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Wauth"] = ExpressionConverter.Convert(wauth);
                return new ApiConnectionAction<GetTestsuiteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waaila")]
        [WorkflowExpressionFactory(nameof(__BuildGetToken))]
        public IBodyWorkflowAction<GetTokenResponse> GetToken([WorkflowExpression] Func<string> bodycode, [WorkflowExpression] Func<string> bodyemail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waaila")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTokenResponse> __BuildGetToken(WorkflowExpression<string> bodycode, WorkflowExpression<string> bodyemail)
        {
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<GetTokenResponse>(() =>
            {
                var apiCallPath = "/v1/auth/exchange-api-code";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class GetTestsuiteResponse
    {
        [JsonProperty("customName")]
        public string CustomName { get; set; }

        [JsonProperty("results")]
        public GetTestsuiteResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("datasource")]
        public GetTestsuiteResponseDatasourceType Datasource { get; set; }

        [JsonProperty("datasourceId")]
        public string DatasourceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tests")]
        public GetTestsuiteResponseTestsTypeItem[] Tests { get; set; }

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

    public class GetTestsuiteResponseResultsTypeItem
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

    public class GetTestsuiteResponseDatasourceType
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
        public GetTestsuiteResponseDatasourceTypeAccountType Account { get; set; }

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

    public class GetTestsuiteResponseDatasourceTypeAccountType
    {
        [JsonProperty("authentication")]
        public GetTestsuiteResponseDatasourceTypeAccountTypeAuthenticationType Authentication { get; set; }

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

    public class GetTestsuiteResponseDatasourceTypeAccountTypeAuthenticationType
    {
        [JsonProperty("googleId")]
        public string GoogleId { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("accessTokenExpirationDate")]
        public string AccessTokenExpirationDate { get; set; }

        [JsonProperty("headers")]
        public GetTestsuiteResponseDatasourceTypeAccountTypeAuthenticationTypeHeadersType Headers { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("authenticationType")]
        public string AuthenticationType { get; set; }

        [JsonProperty("scopes")]
        public string[] Scopes { get; set; }
    }

    public class GetTestsuiteResponseDatasourceTypeAccountTypeAuthenticationTypeHeadersType
    {
        public string Authorization { get; set; }
    }

    public class GetTestsuiteResponseTestsTypeItem
    {
        [JsonProperty("maxScore")]
        public int MaxScore { get; set; }

        [JsonProperty("testedAt")]
        public string TestedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("queryLogic")]
        public string QueryLogic { get; set; }

        [JsonProperty("testType")]
        public string TestType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("testLogic")]
        public string TestLogic { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("sourceTestsetId")]
        public string SourceTestsetId { get; set; }

        [JsonProperty("sourceTestId")]
        public string SourceTestId { get; set; }

        [JsonProperty("??ourceLibraryId")]
        public string OurceLibraryId { get; set; }

        [JsonProperty("sourceVersion")]
        public int SourceVersion { get; set; }

        [JsonProperty("sourceUpdated")]
        public bool SourceUpdated { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }
    }

    public class GetTokenResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }
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