//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamics365ratingsre
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Dynamics365ratingsreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamics365ratingsre")]
        public IBodyWorkflowAction<string> SubmitReview([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> productId, [WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> locale, [WorkflowExpression] Func<string> encodedUser, [WorkflowExpression] Func<string> bodyrating, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<string> channelId = null, [WorkflowExpression] Func<string> market = null, [WorkflowExpression] Func<string> bodysku = null, [WorkflowExpression] Func<string> bodylegalEntity = null, [WorkflowExpression] Func<string> bodysubmittedDateTime = null)
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
            body["Rating"] = ExpressionConverter.ConvertO(bodyrating);
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            bodypropCount++;
            body["ReviewText"] = ExpressionConverter.ConvertO(bodyreviewText);
            if (bodysku != null)
            {
                body["Sku"] = ExpressionConverter.ConvertO(bodysku);
                bodypropCount++;
            }

            bodypropCount++;
            body["ProductName"] = ExpressionConverter.ConvertO(bodyproductName);
            if (bodylegalEntity != null)
            {
                body["LegalEntity"] = ExpressionConverter.ConvertO(bodylegalEntity);
                bodypropCount++;
            }

            var extendedPropertiesObject = new JObject();
            var extendedPropertiesObjectpropCount = 0;
            if (extendedPropertiesObjectpropCount > 0)
            {
                body["ExtendedProperties"] = extendedPropertiesObject;
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
        public IBodyWorkflowAction<ExportSuccessfulResponse> ExportReviews([WorkflowExpression] Func<string> tenantId)
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