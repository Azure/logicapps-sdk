//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Apptigentpowertoolspro
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApptigentpowertoolsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apptigentpowertoolspro")]
        public IWorkflowAction CompositeImage(Expression<Func<positionInput>> position, Expression<Func<double>> opacity, Expression<Func<object>> background, Expression<Func<object>> foreground, Expression<Func<double>> horizontal = null, Expression<Func<double>> vertical = null, Expression<Func<string>> filename = null)
        {
            var apiCallPath = "/CompositeImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class ApptigentpowertoolsproTriggers([ConnectionName] string connectionId)
    {
    }

    public enum positionInput
    {
        Custom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Center")]
        TopCenter,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Middle Left")]
        MiddleLeft,
        [EnumMember(Value = "Middle Center")]
        MiddleCenter,
        [EnumMember(Value = "Middle Right")]
        MiddleRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Center")]
        BottomCenter,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Apptigentpowertoolspro;

    public partial class WorkflowManagedActions
    {
        public ApptigentpowertoolsproActions Apptigentpowertoolspro(string connectionId) => new ApptigentpowertoolsproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApptigentpowertoolsproTriggers Apptigentpowertoolspro(string connectionId) => new ApptigentpowertoolsproTriggers(connectionId);
    }
}