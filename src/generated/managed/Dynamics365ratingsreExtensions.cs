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
            var __workflow_productId = productId == null ? null : WorkflowExpression.Compile(productId);
            WorkflowExpression.Validate(__workflow_productId, nameof(productId), required: true);
            var __workflow_tenantId = tenantId == null ? null : WorkflowExpression.Compile(tenantId);
            WorkflowExpression.Validate(__workflow_tenantId, nameof(tenantId), required: true);
            var __workflow_locale = locale == null ? null : WorkflowExpression.Compile(locale);
            WorkflowExpression.Validate(__workflow_locale, nameof(locale), required: true);
            var __workflow_encodedUser = encodedUser == null ? null : WorkflowExpression.Compile(encodedUser);
            WorkflowExpression.Validate(__workflow_encodedUser, nameof(encodedUser), required: true);
            var __workflow_bodyrating = bodyrating == null ? null : WorkflowExpression.Compile(bodyrating);
            WorkflowExpression.Validate(__workflow_bodyrating, nameof(bodyrating), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyreviewText = bodyreviewText == null ? null : WorkflowExpression.Compile(bodyreviewText);
            WorkflowExpression.Validate(__workflow_bodyreviewText, nameof(bodyreviewText), required: true);
            var __workflow_bodyproductName = bodyproductName == null ? null : WorkflowExpression.Compile(bodyproductName);
            WorkflowExpression.Validate(__workflow_bodyproductName, nameof(bodyproductName), required: true);
            var __workflow_channelId = channelId == null ? null : WorkflowExpression.Compile(channelId);
            WorkflowExpression.Validate(__workflow_channelId, nameof(channelId), required: false);
            var __workflow_market = market == null ? null : WorkflowExpression.Compile(market);
            WorkflowExpression.Validate(__workflow_market, nameof(market), required: false);
            var __workflow_bodysku = bodysku == null ? null : WorkflowExpression.Compile(bodysku);
            WorkflowExpression.Validate(__workflow_bodysku, nameof(bodysku), required: false);
            var __workflow_bodylegalEntity = bodylegalEntity == null ? null : WorkflowExpression.Compile(bodylegalEntity);
            WorkflowExpression.Validate(__workflow_bodylegalEntity, nameof(bodylegalEntity), required: false);
            var __workflow_bodysubmittedDateTime = bodysubmittedDateTime == null ? null : WorkflowExpression.Compile(bodysubmittedDateTime);
            WorkflowExpression.Validate(__workflow_bodysubmittedDateTime, nameof(bodysubmittedDateTime), required: false);
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
            var __workflow_tenantId = tenantId == null ? null : WorkflowExpression.Compile(tenantId);
            WorkflowExpression.Validate(__workflow_tenantId, nameof(tenantId), required: true);
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
