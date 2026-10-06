//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientworkflowauto
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientworkflowautoActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientworkflowauto")]
        [WorkflowExpressionFactory(nameof(__BuildSubmitForm))]
        public IBodyWorkflowAction<SubmitFormResponse> SubmitForm([WorkflowExpression] Func<string> processGuid, [WorkflowExpression] Func<string> processTaskGuid, [WorkflowExpression] Func<object> dynamicListSchema = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientworkflowauto")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubmitFormResponse> __BuildSubmitForm(WorkflowExpression<string> processGuid, WorkflowExpression<string> processTaskGuid, WorkflowExpression<object> dynamicListSchema = null)
        {
            WorkflowExpression.Validate(processGuid, nameof(processGuid), required: true);
            WorkflowExpression.Validate(processTaskGuid, nameof(processTaskGuid), required: true);
            WorkflowExpression.Validate(dynamicListSchema, nameof(dynamicListSchema), required: false);
            return new DeferredBodyAction<SubmitFormResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/instance/start/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(processGuid, 1), ExpressionConverter.ConvertWithUrlEncoding(processTaskGuid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(dynamicListSchema);
                return new ApiConnectionAction<SubmitFormResponse>(callPayload);
            });
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