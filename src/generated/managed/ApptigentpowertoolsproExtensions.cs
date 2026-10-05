//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apptigentpowertoolspro
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApptigentpowertoolsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apptigentpowertoolspro")]
        [WorkflowExpressionFactory(nameof(__BuildCompositeImage))]
        public IWorkflowAction CompositeImage([WorkflowExpression] Func<positionInput> position, [WorkflowExpression] Func<double> opacity, [WorkflowExpression] Func<object> background, [WorkflowExpression] Func<object> foreground, [WorkflowExpression] Func<double> horizontal = null, [WorkflowExpression] Func<double> vertical = null, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompositeImage(WorkflowValue<positionInput> position, WorkflowValue<double> opacity, WorkflowValue<object> background, WorkflowValue<object> foreground, WorkflowValue<double> horizontal = null, WorkflowValue<double> vertical = null, WorkflowValue<string> filename = null)
        {
            WorkflowValue.Validate(position, nameof(position), required: true);
            WorkflowValue.Validate(opacity, nameof(opacity), required: true);
            WorkflowValue.Validate(background, nameof(background), required: true);
            WorkflowValue.Validate(foreground, nameof(foreground), required: true);
            WorkflowValue.Validate(horizontal, nameof(horizontal), required: false);
            WorkflowValue.Validate(vertical, nameof(vertical), required: false);
            WorkflowValue.Validate(filename, nameof(filename), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/CompositeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Apptigentpowertoolspro;

    public partial class WorkflowManagedActions
    {
        public ApptigentpowertoolsproActions Apptigentpowertoolspro(string connectionId) => new ApptigentpowertoolsproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApptigentpowertoolsproTriggers Apptigentpowertoolspro(string connectionId) => new ApptigentpowertoolsproTriggers(connectionId);
    }
}
