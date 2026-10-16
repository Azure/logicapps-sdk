//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientworkflowauto
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientworkflowautoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientworkflowauto")]
        public IBodyWorkflowAction<SubmitFormResponse> SubmitForm(Expression<Func<string>> processGuid, Expression<Func<string>> processTaskGuid, Expression<Func<object>> dynamicListSchema = null)
        {
            var __workflow_processGuid = WorkflowExpression.Compile(processGuid, nameof(processGuid), required: true);
            var __workflow_processTaskGuid = WorkflowExpression.Compile(processTaskGuid, nameof(processTaskGuid), required: true);
            var __workflow_dynamicListSchema = WorkflowExpression.Compile(dynamicListSchema, nameof(dynamicListSchema), required: false);
            return new DeferredBodyAction<SubmitFormResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/instance/start/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_processGuid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_processTaskGuid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicListSchema);
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
