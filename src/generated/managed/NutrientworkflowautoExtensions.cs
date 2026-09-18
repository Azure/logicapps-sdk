//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientworkflowauto
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientworkflowautoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientworkflowauto")]
        public IBodyWorkflowAction<SubmitFormResponse> SubmitForm([WorkflowExpression] Func<string> processGuid, [WorkflowExpression] Func<string> processTaskGuid, [WorkflowExpression] Func<object> dynamicListSchema = null)
        {
            SourceExpression.Validate(processGuid, nameof(processGuid), required: true);
            SourceExpression.Validate(processTaskGuid, nameof(processTaskGuid), required: true);
            SourceExpression.Validate(dynamicListSchema, nameof(dynamicListSchema), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/instance/start/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(processGuid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(processTaskGuid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(dynamicListSchema);
                return callPayload;
            }

            return new ApiConnectionAction<SubmitFormResponse>(BuildSourceInput);
        }
    }

    public class NutrientworkflowautoTriggers([ConnectionName] string connectionId)
    {
    }

    public class SubmitFormResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientworkflowauto;

    public partial class WorkflowManagedActions
    {
        public NutrientworkflowautoActions Nutrientworkflowauto(string connectionId) => new NutrientworkflowautoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NutrientworkflowautoTriggers Nutrientworkflowauto(string connectionId) => new NutrientworkflowautoTriggers(connectionId);
    }
}