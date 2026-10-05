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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBadgeCreate(WorkflowValue<string> label = null, WorkflowValue<string> labelColor = null, WorkflowValue<string> message = null, WorkflowValue<string> color = null, WorkflowValue<string> style = null, WorkflowValue<string> logo = null, WorkflowValue<string> logoColor = null, WorkflowValue<int> logoWidth = null, WorkflowValue<string> link = null, WorkflowValue<int> cacheSeconds = null)
        {
            WorkflowValue.Validate(label, nameof(label), required: false);
            WorkflowValue.Validate(labelColor, nameof(labelColor), required: false);
            WorkflowValue.Validate(message, nameof(message), required: false);
            WorkflowValue.Validate(color, nameof(color), required: false);
            WorkflowValue.Validate(style, nameof(style), required: false);
            WorkflowValue.Validate(logo, nameof(logo), required: false);
            WorkflowValue.Validate(logoColor, nameof(logoColor), required: false);
            WorkflowValue.Validate(logoWidth, nameof(logoWidth), required: false);
            WorkflowValue.Validate(link, nameof(link), required: false);
            WorkflowValue.Validate(cacheSeconds, nameof(cacheSeconds), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBadgeGet(WorkflowValue<string> parameters)
        {
            WorkflowValue.Validate(parameters, nameof(parameters), required: true);
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
