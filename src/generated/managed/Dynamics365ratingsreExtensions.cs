//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamics365ratingsre
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Dynamics365ratingsreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamics365ratingsre")]
        public IBodyWorkflowAction<string> SubmitReview(Expression<Func<string>> productId, Expression<Func<string>> tenantId, Expression<Func<string>> locale, Expression<Func<string>> encodedUser, Expression<Func<string>> bodyRating, Expression<Func<string>> bodyTitle, Expression<Func<string>> bodyReviewText, Expression<Func<string>> bodyProductName, Expression<Func<string>> channelId = null, Expression<Func<string>> market = null, Expression<Func<string>> bodySku = null, Expression<Func<string>> bodyLegalEntity = null, Expression<Func<string>> bodysubmittedDateTime = null)
        {
            var apiCallPath = String.Format("/v2.0/reviews/product/{0}/user", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            if (channelId != null)
                callPayload.Queries["channelId"] = ExpressionConverter.Convert(channelId);
            if (market != null)
                callPayload.Queries["market"] = ExpressionConverter.Convert(market);
            callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
            callPayload.Queries["encodedUser"] = ExpressionConverter.Convert(encodedUser);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Rating"] = ExpressionConverter.ConvertO(bodyRating);
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
            bodypropCount++;
            body["ReviewText"] = ExpressionConverter.ConvertO(bodyReviewText);
            if (bodySku != null)
            {
                body["Sku"] = ExpressionConverter.ConvertO(bodySku);
                bodypropCount++;
            }

            bodypropCount++;
            body["ProductName"] = ExpressionConverter.ConvertO(bodyProductName);
            if (bodyLegalEntity != null)
            {
                body["LegalEntity"] = ExpressionConverter.ConvertO(bodyLegalEntity);
                bodypropCount++;
            }

            var ExtendedPropertiesObject = new JObject();
            var ExtendedPropertiesObjectpropCount = 0;
            if (ExtendedPropertiesObjectpropCount > 0)
            {
                body["ExtendedProperties"] = ExtendedPropertiesObject;
                bodypropCount++;
            }

            if (bodysubmittedDateTime != null)
            {
                body["submittedDateTime"] = ExpressionConverter.ConvertO(bodysubmittedDateTime);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamics365ratingsre")]
        public IBodyWorkflowAction<ExportSuccessfulResponse> ExportReviews(Expression<Func<string>> tenantId)
        {
            var apiCallPath = "/v2.0/export/reviews/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            return new ApiConnectionAction<ExportSuccessfulResponse>(callPayload);
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