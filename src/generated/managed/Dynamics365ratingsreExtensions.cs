//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamics365ratingsre
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Dynamics365ratingsreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamics365ratingsre")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SubmitReview(Expression<Func<string>> productId, Expression<Func<string>> tenantId, Expression<Func<string>> locale, Expression<Func<string>> encodedUser, Expression<Func<SubmitReviewInput>> body, Expression<Func<string>> channelId = null, Expression<Func<string>> market = null)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_locale = WorkflowExpression.Compile(locale, nameof(locale), required: true);
            var __workflow_encodedUser = WorkflowExpression.Compile(encodedUser, nameof(encodedUser), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: false);
            var __workflow_market = WorkflowExpression.Compile(market, nameof(market), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2.0/reviews/product/{0}/user", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                if (__workflow_channelId != null)
                    callPayload.Queries["channelId"] = ExpressionConverter.Convert(__workflow_channelId);
                if (__workflow_market != null)
                    callPayload.Queries["market"] = ExpressionConverter.Convert(__workflow_market);
                callPayload.Queries["locale"] = ExpressionConverter.Convert(__workflow_locale);
                callPayload.Queries["encodedUser"] = ExpressionConverter.Convert(__workflow_encodedUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamics365ratingsre")]
        public IBodyWorkflowAction<ExportSuccessfulResponse, ApiConnectionActionConfiguration> ExportReviews(Expression<Func<string>> tenantId)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            return new DeferredBodyAction<ExportSuccessfulResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/export/reviews/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                return new ApiConnectionAction<ExportSuccessfulResponse>(callPayload);
            });
        }
    }

    public class Dynamics365ratingsreTriggers([ConnectionName] string connectionId)
    {
    }

    public class SubmitReviewInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Rating { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReviewText { get; set; }
        public string Sku { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProductName { get; set; }
        public string LegalEntity { get; set; }
        public JToken ExtendedProperties { get; set; }

        [JsonProperty("submittedDateTime")]
        public string SubmittedDateTime { get; set; }
    }

    public class ExportSuccessfulResponse
    {
        [JsonProperty("blobSasUrl")]
        public string BlobSasUrl { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamics365ratingsre;

    public partial class WorkflowManagedActions
    {
        public Dynamics365ratingsreActions Dynamics365ratingsre(string connectionId) => new Dynamics365ratingsreActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Dynamics365ratingsreTriggers Dynamics365ratingsre(string connectionId) => new Dynamics365ratingsreTriggers(connectionId);
    }
}