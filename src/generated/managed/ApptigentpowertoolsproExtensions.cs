//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apptigentpowertoolspro
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ApptigentpowertoolsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apptigentpowertoolspro")]
        public IWorkflowAction CompositeImage(Expression<Func<positionInput>> position, Expression<Func<double>> opacity, Expression<Func<object>> background, Expression<Func<object>> foreground, Expression<Func<double>> horizontal = null, Expression<Func<double>> vertical = null, Expression<Func<string>> filename = null)
        {
            var __workflow_position = position == null ? null : WorkflowExpression.Compile(position);
            WorkflowExpression.Validate(__workflow_position, nameof(position), required: true);
            var __workflow_opacity = opacity == null ? null : WorkflowExpression.Compile(opacity);
            WorkflowExpression.Validate(__workflow_opacity, nameof(opacity), required: true);
            var __workflow_background = background == null ? null : WorkflowExpression.Compile(background);
            WorkflowExpression.Validate(__workflow_background, nameof(background), required: true);
            var __workflow_foreground = foreground == null ? null : WorkflowExpression.Compile(foreground);
            WorkflowExpression.Validate(__workflow_foreground, nameof(foreground), required: true);
            var __workflow_horizontal = horizontal == null ? null : WorkflowExpression.Compile(horizontal);
            WorkflowExpression.Validate(__workflow_horizontal, nameof(horizontal), required: false);
            var __workflow_vertical = vertical == null ? null : WorkflowExpression.Compile(vertical);
            WorkflowExpression.Validate(__workflow_vertical, nameof(vertical), required: false);
            var __workflow_filename = filename == null ? null : WorkflowExpression.Compile(filename);
            WorkflowExpression.Validate(__workflow_filename, nameof(filename), required: false);
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
