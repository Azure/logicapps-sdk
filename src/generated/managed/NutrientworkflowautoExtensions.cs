//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Nutrientworkflowauto
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientworkflowautoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientworkflowauto")]
        public IBodyWorkflowAction<SubmitFormResponse> SubmitForm(Expression<Func<string>> processGuid, Expression<Func<string>> processTaskGuid, Expression<Func<object>> dynamicListSchema = null)
        {
            var apiCallPath = String.Format("/api/instance/start/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(processGuid, 1), ExpressionConverter.ConvertWithUrlEncoding(processTaskGuid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicListSchema);
            return new ApiConnectionAction<SubmitFormResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Nutrientworkflowauto;

    public partial class WorkflowManagedActions
    {
        public NutrientworkflowautoActions Nutrientworkflowauto(string connectionId) => new NutrientworkflowautoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NutrientworkflowautoTriggers Nutrientworkflowauto(string connectionId) => new NutrientworkflowautoTriggers(connectionId);
    }
}