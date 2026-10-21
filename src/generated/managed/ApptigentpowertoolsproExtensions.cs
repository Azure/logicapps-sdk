//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apptigentpowertoolspro
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApptigentpowertoolsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apptigentpowertoolspro")]
        public IWorkflowAction CompositeImage(Expression<Func<positionInput>> position, Expression<Func<double>> opacity, Expression<Func<object>> background, Expression<Func<object>> foreground, Expression<Func<double>> horizontal = null, Expression<Func<double>> vertical = null, Expression<Func<string>> filename = null)
        {
            var __workflow_position = WorkflowExpression.Compile(position, nameof(position), required: true);
            var __workflow_opacity = WorkflowExpression.Compile(opacity, nameof(opacity), required: true);
            var __workflow_background = WorkflowExpression.Compile(background, nameof(background), required: true);
            var __workflow_foreground = WorkflowExpression.Compile(foreground, nameof(foreground), required: true);
            var __workflow_horizontal = WorkflowExpression.Compile(horizontal, nameof(horizontal), required: false);
            var __workflow_vertical = WorkflowExpression.Compile(vertical, nameof(vertical), required: false);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/CompositeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class ApptigentpowertoolsproTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
