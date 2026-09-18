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
        public IBodyWorkflowAction<string> SubmitReview([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> locale, [WorkflowExpression] Func<string> encodedUser, [WorkflowExpression] Func<string> bodyrating, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<string> channelId = null, [WorkflowExpression] Func<string> market = null, [WorkflowExpression] Func<string> bodysku = null, [WorkflowExpression] Func<string> bodylegalEntity = null, [WorkflowExpression] Func<string> bodysubmittedDateTime = null)
        {
            SourceExpression.Validate(productId, nameof(productId), required: true);
            SourceExpression.Validate(tenantId, nameof(tenantId), required: true);
            SourceExpression.Validate(locale, nameof(locale), required: true);
            SourceExpression.Validate(encodedUser, nameof(encodedUser), required: true);
            SourceExpression.Validate(bodyrating, nameof(bodyrating), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodyreviewText, nameof(bodyreviewText), required: true);
            SourceExpression.Validate(bodyproductName, nameof(bodyproductName), required: true);
            SourceExpression.Validate(channelId, nameof(channelId), required: false);
            SourceExpression.Validate(market, nameof(market), required: false);
            SourceExpression.Validate(bodysku, nameof(bodysku), required: false);
            SourceExpression.Validate(bodylegalEntity, nameof(bodylegalEntity), required: false);
            SourceExpression.Validate(bodysubmittedDateTime, nameof(bodysubmittedDateTime), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2.0/reviews/product/{0}/user", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = SourceExpressionConverter.ConvertO(tenantId);
                if (channelId != null)
                    callPayload.Queries["channelId"] = SourceExpressionConverter.ConvertO(channelId);
                if (market != null)
                    callPayload.Queries["market"] = SourceExpressionConverter.ConvertO(market);
                callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                callPayload.Queries["encodedUser"] = SourceExpressionConverter.ConvertO(encodedUser);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Rating"] = SourceExpressionConverter.ConvertToken(bodyrating);
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["ReviewText"] = SourceExpressionConverter.ConvertToken(bodyreviewText);
                if (bodysku != null)
                {
                    body["Sku"] = SourceExpressionConverter.ConvertToken(bodysku);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ProductName"] = SourceExpressionConverter.ConvertToken(bodyproductName);
                if (bodylegalEntity != null)
                {
                    body["LegalEntity"] = SourceExpressionConverter.ConvertToken(bodylegalEntity);
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
                    body["submittedDateTime"] = SourceExpressionConverter.ConvertToken(bodysubmittedDateTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamics365ratingsre")]
        public IBodyWorkflowAction<ExportSuccessfulResponse> ExportReviews([WorkflowExpression] Func<string> tenantId)
        {
            SourceExpression.Validate(tenantId, nameof(tenantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.0/export/reviews/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = SourceExpressionConverter.ConvertO(tenantId);
                return callPayload;
            }

            return new ApiConnectionAction<ExportSuccessfulResponse>(BuildSourceInput);
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