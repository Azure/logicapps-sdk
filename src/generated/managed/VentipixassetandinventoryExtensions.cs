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
            var apiCallPath = String.Format("/app/flow/fetchsert/{0}", ExpressionConverter.ConvertWithUrlEncoding(listIDDynamic, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["barcode_value"] = ExpressionConverter.Convert(barcodeValue);
            if (location != null)
                callPayload.Queries["location"] = ExpressionConverter.Convert(location);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        public IWorkflowAction CreateListItem(Expression<Func<string>> listIDDynamic, Expression<Func<object>> dynamicListSchema = null)
        {
            var apiCallPath = String.Format("/app/flow/fetchsert/{0}", ExpressionConverter.ConvertWithUrlEncoding(listIDDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicListSchema);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class VentipixassetandinventoryTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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