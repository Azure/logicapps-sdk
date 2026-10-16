//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamics365ratingsre
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Dynamics365ratingsreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamics365ratingsre")]
        public IBodyWorkflowAction<string> SubmitReview(Expression<Func<string>> productId, Expression<Func<string>> tenantId, Expression<Func<string>> locale, Expression<Func<string>> encodedUser, Expression<Func<string>> bodyrating, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyreviewText, Expression<Func<string>> bodyproductName, Expression<Func<string>> channelId = null, Expression<Func<string>> market = null, Expression<Func<string>> bodysku = null, Expression<Func<string>> bodylegalEntity = null, Expression<Func<string>> bodysubmittedDateTime = null)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_locale = WorkflowExpression.Compile(locale, nameof(locale), required: true);
            var __workflow_encodedUser = WorkflowExpression.Compile(encodedUser, nameof(encodedUser), required: true);
            var __workflow_bodyrating = WorkflowExpression.Compile(bodyrating, nameof(bodyrating), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyreviewText = WorkflowExpression.Compile(bodyreviewText, nameof(bodyreviewText), required: true);
            var __workflow_bodyproductName = WorkflowExpression.Compile(bodyproductName, nameof(bodyproductName), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: false);
            var __workflow_market = WorkflowExpression.Compile(market, nameof(market), required: false);
            var __workflow_bodysku = WorkflowExpression.Compile(bodysku, nameof(bodysku), required: false);
            var __workflow_bodylegalEntity = WorkflowExpression.Compile(bodylegalEntity, nameof(bodylegalEntity), required: false);
            var __workflow_bodysubmittedDateTime = WorkflowExpression.Compile(bodysubmittedDateTime, nameof(bodysubmittedDateTime), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2.0/reviews/product/{0}/user", ExpressionConverter.ConvertWithUrlEncoding(__workflow_productId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                if (__workflow_channelId != null)
                    callPayload.Queries["channelId"] = ExpressionConverter.Convert(__workflow_channelId);
                if (__workflow_market != null)
                    callPayload.Queries["market"] = ExpressionConverter.Convert(__workflow_market);
                callPayload.Queries["locale"] = ExpressionConverter.Convert(__workflow_locale);
                callPayload.Queries["encodedUser"] = ExpressionConverter.Convert(__workflow_encodedUser);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Rating"] = ExpressionConverter.ConvertO(__workflow_bodyrating);
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["ReviewText"] = ExpressionConverter.ConvertO(__workflow_bodyreviewText);
                if (__workflow_bodysku != null)
                {
                    body["Sku"] = ExpressionConverter.ConvertO(__workflow_bodysku);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ProductName"] = ExpressionConverter.ConvertO(__workflow_bodyproductName);
                if (__workflow_bodylegalEntity != null)
                {
                    body["LegalEntity"] = ExpressionConverter.ConvertO(__workflow_bodylegalEntity);
                    bodypropCount++;
                }

                var extendedPropertiesObject = new JObject();
                var extendedPropertiesObjectpropCount = 0;
                if (extendedPropertiesObjectpropCount > 0)
                {
                    body["ExtendedProperties"] = extendedPropertiesObject;
                    bodypropCount++;
                }

                if (__workflow_bodysubmittedDateTime != null)
                {
                    body["submittedDateTime"] = ExpressionConverter.ConvertO(__workflow_bodysubmittedDateTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamics365ratingsre")]
        public IBodyWorkflowAction<ExportSuccessfulResponse> ExportReviews(Expression<Func<string>> tenantId)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            return new DeferredBodyAction<ExportSuccessfulResponse>(() =>
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
