//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apptigentpowertoolspro
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApptigentpowertoolsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apptigentpowertoolspro")]
        public IWorkflowAction CompositeImage([WorkflowExpression] Func<positionInput> position, [WorkflowExpression] Func<double> opacity, [WorkflowExpression] Func<object> background, [WorkflowExpression] Func<object> foreground, [WorkflowExpression] Func<double> horizontal = null, [WorkflowExpression] Func<double> vertical = null, [WorkflowExpression] Func<string> filename = null)
        {
            SourceExpression.Validate(position, nameof(position), required: true);
            SourceExpression.Validate(opacity, nameof(opacity), required: true);
            SourceExpression.Validate(background, nameof(background), required: true);
            SourceExpression.Validate(foreground, nameof(foreground), required: true);
            SourceExpression.Validate(horizontal, nameof(horizontal), required: false);
            SourceExpression.Validate(vertical, nameof(vertical), required: false);
            SourceExpression.Validate(filename, nameof(filename), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CompositeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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