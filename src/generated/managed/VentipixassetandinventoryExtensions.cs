//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ventipixassetandinventory
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VentipixassetandinventoryActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        [WorkflowExpressionFactory(nameof(__BuildGetListItems))]
        public IBodyWorkflowAction<JToken> GetListItems([WorkflowExpression] Func<string> listIDDynamic, [WorkflowExpression] Func<string> barcodeValue, [WorkflowExpression] Func<string> location = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetListItems(WorkflowExpression<string> listIDDynamic, WorkflowExpression<string> barcodeValue, WorkflowExpression<string> location = null)
        {
            WorkflowExpression.Validate(listIDDynamic, nameof(listIDDynamic), required: true);
            WorkflowExpression.Validate(barcodeValue, nameof(barcodeValue), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/app/flow/fetchsert/{0}", ExpressionConverter.ConvertWithUrlEncoding(listIDDynamic, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["barcode_value"] = ExpressionConverter.Convert(barcodeValue);
                if (location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(location);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        [WorkflowExpressionFactory(nameof(__BuildCreateListItem))]
        public IWorkflowAction CreateListItem([WorkflowExpression] Func<string> listIDDynamic, [WorkflowExpression] Func<object> dynamicListSchema = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateListItem(WorkflowExpression<string> listIDDynamic, WorkflowExpression<object> dynamicListSchema = null)
        {
            WorkflowExpression.Validate(listIDDynamic, nameof(listIDDynamic), required: true);
            WorkflowExpression.Validate(dynamicListSchema, nameof(dynamicListSchema), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/app/flow/fetchsert/{0}", ExpressionConverter.ConvertWithUrlEncoding(listIDDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(dynamicListSchema);
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