//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Usb4sap
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Usb4sapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usb4sap")]
        public IWorkflowAction GetCallExtractMetadata([WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<string> format = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sap/opu/odata/ECOS/OBJ2CLOUD_V2_SRV/ET_DatasetSet";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (format != null)
                    callPayload.Queries["$format"] = SourceExpressionConverter.ConvertO(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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