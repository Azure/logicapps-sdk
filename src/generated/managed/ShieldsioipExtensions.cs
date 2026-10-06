//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shieldsioip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShieldsioipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        [WorkflowExpressionFactory(nameof(__BuildBadgeCreate))]
        public IBodyWorkflowAction<JToken> BadgeCreate([WorkflowExpression] Func<string> label = null, [WorkflowExpression] Func<string> labelColor = null, [WorkflowExpression] Func<string> message = null, [WorkflowExpression] Func<string> color = null, [WorkflowExpression] Func<string> style = null, [WorkflowExpression] Func<string> logo = null, [WorkflowExpression] Func<string> logoColor = null, [WorkflowExpression] Func<int> logoWidth = null, [WorkflowExpression] Func<string> link = null, [WorkflowExpression] Func<int> cacheSeconds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBadgeCreate(WorkflowExpression<string> label = null, WorkflowExpression<string> labelColor = null, WorkflowExpression<string> message = null, WorkflowExpression<string> color = null, WorkflowExpression<string> style = null, WorkflowExpression<string> logo = null, WorkflowExpression<string> logoColor = null, WorkflowExpression<int> logoWidth = null, WorkflowExpression<string> link = null, WorkflowExpression<int> cacheSeconds = null)
        {
            WorkflowExpression.Validate(label, nameof(label), required: false);
            WorkflowExpression.Validate(labelColor, nameof(labelColor), required: false);
            WorkflowExpression.Validate(message, nameof(message), required: false);
            WorkflowExpression.Validate(color, nameof(color), required: false);
            WorkflowExpression.Validate(style, nameof(style), required: false);
            WorkflowExpression.Validate(logo, nameof(logo), required: false);
            WorkflowExpression.Validate(logoColor, nameof(logoColor), required: false);
            WorkflowExpression.Validate(logoWidth, nameof(logoWidth), required: false);
            WorkflowExpression.Validate(link, nameof(link), required: false);
            WorkflowExpression.Validate(cacheSeconds, nameof(cacheSeconds), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/static/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (label != null)
                    callPayload.Queries["label"] = ExpressionConverter.Convert(label);
                if (labelColor != null)
                    callPayload.Queries["labelColor"] = ExpressionConverter.Convert(labelColor);
                if (message != null)
                    callPayload.Queries["message"] = ExpressionConverter.Convert(message);
                if (color != null)
                    callPayload.Queries["color"] = ExpressionConverter.Convert(color);
                if (style != null)
                    callPayload.Queries["style"] = ExpressionConverter.Convert(style);
                if (logo != null)
                    callPayload.Queries["logo"] = ExpressionConverter.Convert(logo);
                if (logoColor != null)
                    callPayload.Queries["logoColor"] = ExpressionConverter.Convert(logoColor);
                if (logoWidth != null)
                    callPayload.Queries["logoWidth"] = ExpressionConverter.Convert(logoWidth);
                if (link != null)
                    callPayload.Queries["link"] = ExpressionConverter.Convert(link);
                callPayload.Queries["cacheSeconds"] = Convert.ToString(3600);
                if (cacheSeconds != null)
                    callPayload.Queries["cacheSeconds"] = ExpressionConverter.Convert(cacheSeconds);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        [WorkflowExpressionFactory(nameof(__BuildBadgeGet))]
        public IBodyWorkflowAction<JToken> BadgeGet([WorkflowExpression] Func<string> parameters)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBadgeGet(WorkflowExpression<string> parameters)
        {
            WorkflowExpression.Validate(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(parameters, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ShieldsioipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shieldsioip;

    public partial class WorkflowManagedActions
    {
        public ShieldsioipActions Shieldsioip(string connectionId) => new ShieldsioipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShieldsioipTriggers Shieldsioip(string connectionId) => new ShieldsioipTriggers(connectionId);
    }
}