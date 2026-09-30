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
        public IBodyWorkflowAction<JToken> GetListItems([WorkflowExpression] Func<string> listIdDynamic, [WorkflowExpression] Func<string> barcodeValue, [WorkflowExpression] Func<string> location = null)
        {
            SourceExpression.Validate(listIdDynamic, nameof(listIdDynamic), required: true);
            SourceExpression.Validate(barcodeValue, nameof(barcodeValue), required: true);
            SourceExpression.Validate(location, nameof(location), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/app/flow/fetchsert/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listIdDynamic, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["barcode_value"] = SourceExpressionConverter.ConvertO(barcodeValue);
                if (location != null)
                    callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ventipixassetandinventory")]
        public IWorkflowAction CreateListItem([WorkflowExpression] Func<string> listIdDynamic, [WorkflowExpression] Func<object> dynamicListSchema = null)
        {
            SourceExpression.Validate(listIdDynamic, nameof(listIdDynamic), required: true);
            SourceExpression.Validate(dynamicListSchema, nameof(dynamicListSchema), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/app/flow/fetchsert/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listIdDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(dynamicListSchema);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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