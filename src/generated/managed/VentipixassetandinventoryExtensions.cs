//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ventipixassetandinventory
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VentipixassetandinventoryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetListItems(Expression<Func<string>> listIdDynamic, Expression<Func<string>> barcodeValue, Expression<Func<string>> location = null)
        {
            var __workflow_listIdDynamic = WorkflowExpression.Compile(listIdDynamic, nameof(listIdDynamic), required: true);
            var __workflow_barcodeValue = WorkflowExpression.Compile(barcodeValue, nameof(barcodeValue), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/flow/fetchsert/{0}", __workflow_listIdDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["barcode_value"] = ExpressionConverter.Convert(__workflow_barcodeValue);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateListItem(Expression<Func<string>> listIdDynamic, Expression<Func<object>> dynamicListSchema = null)
        {
            var __workflow_listIdDynamic = WorkflowExpression.Compile(listIdDynamic, nameof(listIdDynamic), required: true);
            var __workflow_dynamicListSchema = WorkflowExpression.Compile(dynamicListSchema, nameof(dynamicListSchema), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/flow/fetchsert/{0}", __workflow_listIdDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dynamicListSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicListSchema);
                return new ApiConnectionAction(callPayload);
            });
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