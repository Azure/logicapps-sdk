//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Myacclaro
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MyacclaroActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myacclaro")]
        public IBodyWorkflowAction<GetAllSupportedOrderTypesResponse> GetAllSupportedOrderTypes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/info/order-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllSupportedOrderTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myacclaro")]
        public IBodyWorkflowAction<string> DeleteAnOrder([WorkflowExpression] Func<string> orderid)
        {
            SourceExpression.Validate(orderid, nameof(orderid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/orders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(orderid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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