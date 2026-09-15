//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ventipixassetandinventory
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VentipixassetandinventoryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        public IBodyWorkflowAction<JToken> GetListItems(Expression<Func<string>> listIDDynamic, Expression<Func<string>> barcodeValue, Expression<Func<string>> location = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/app/flow/fetchsert/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listIDDynamic, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["barcode_value"] = CSharpExpressionConverter.ConvertO(barcodeValue);
            if (location != null)
                callPayload.Queries["location"] = CSharpExpressionConverter.ConvertO(location);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        public IWorkflowAction CreateListItem(Expression<Func<string>> listIDDynamic, Expression<Func<object>> dynamicListSchema = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/app/flow/fetchsert/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listIDDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(dynamicListSchema);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class VentipixassetandinventoryTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ventipixassetandinventory;

    public partial class WorkflowManagedActions
    {
        public VentipixassetandinventoryActions Ventipixassetandinventory(string connectionId) => new VentipixassetandinventoryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VentipixassetandinventoryTriggers Ventipixassetandinventory(string connectionId) => new VentipixassetandinventoryTriggers(connectionId);
    }
}