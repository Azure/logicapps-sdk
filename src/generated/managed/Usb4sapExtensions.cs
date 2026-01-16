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
        public IWorkflowAction GetCallExtractMetadata(Expression<Func<string>> filter, Expression<Func<string>> format = null)
        {
            var apiCallPath = "/sap/opu/odata/ECOS/OBJ2CLOUD_V2_SRV/ET_DatasetSet";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (format != null)
                callPayload.Queries["$format"] = ExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class Usb4sapTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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