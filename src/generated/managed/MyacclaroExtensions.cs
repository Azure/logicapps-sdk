//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Myacclaro
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MyacclaroActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myacclaro")]
        public IBodyWorkflowAction<GetAllSupportedOrderTypesResponse> GetAllSupportedOrderTypes()
        {
            var apiCallPath = "/info/order-types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllSupportedOrderTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myacclaro")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAnOrder))]
        public IBodyWorkflowAction<string> DeleteAnOrder([WorkflowExpression] Func<string> orderid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteAnOrder(WorkflowExpression<string> orderid)
        {
            WorkflowExpression.Validate(orderid, nameof(orderid), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/orders/{0}", ExpressionConverter.ConvertWithUrlEncoding(orderid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class MyacclaroTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAllSupportedOrderTypesResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Myacclaro;

    public partial class WorkflowManagedActions
    {
        public MyacclaroActions Myacclaro(string connectionId) => new MyacclaroActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MyacclaroTriggers Myacclaro(string connectionId) => new MyacclaroTriggers(connectionId);
    }
}