//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Usb4sap
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Usb4sapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usb4sap")]
        [WorkflowExpressionFactory(nameof(__BuildGetCallExtractMetadata))]
        public IWorkflowAction GetCallExtractMetadata([WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<string> format = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetCallExtractMetadata(WorkflowValue<string> filter, WorkflowValue<string> format = null)
        {
            WorkflowValue.Validate(filter, nameof(filter), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/sap/opu/odata/ECOS/OBJ2CLOUD_V2_SRV/ET_DatasetSet";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (format != null)
                    callPayload.Queries["$format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Usb4sapTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Usb4sap;

    public partial class WorkflowManagedActions
    {
        public Usb4sapActions Usb4sap(string connectionId) => new Usb4sapActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Usb4sapTriggers Usb4sap(string connectionId) => new Usb4sapTriggers(connectionId);
    }
}
