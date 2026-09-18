//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shieldsioip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShieldsioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        public IBodyWorkflowAction<JToken> BadgeCreate([WorkflowExpression] Func<string> label = null, [WorkflowExpression] Func<string> labelColor = null, [WorkflowExpression] Func<string> message = null, [WorkflowExpression] Func<string> color = null, [WorkflowExpression] Func<string> style = null, [WorkflowExpression] Func<string> logo = null, [WorkflowExpression] Func<string> logoColor = null, [WorkflowExpression] Func<int> logoWidth = null, [WorkflowExpression] Func<string> link = null, [WorkflowExpression] Func<int> cacheSeconds = null)
        {
            SourceExpression.Validate(label, nameof(label), required: false);
            SourceExpression.Validate(labelColor, nameof(labelColor), required: false);
            SourceExpression.Validate(message, nameof(message), required: false);
            SourceExpression.Validate(color, nameof(color), required: false);
            SourceExpression.Validate(style, nameof(style), required: false);
            SourceExpression.Validate(logo, nameof(logo), required: false);
            SourceExpression.Validate(logoColor, nameof(logoColor), required: false);
            SourceExpression.Validate(logoWidth, nameof(logoWidth), required: false);
            SourceExpression.Validate(link, nameof(link), required: false);
            SourceExpression.Validate(cacheSeconds, nameof(cacheSeconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/static/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (label != null)
                    callPayload.Queries["label"] = SourceExpressionConverter.ConvertO(label);
                if (labelColor != null)
                    callPayload.Queries["labelColor"] = SourceExpressionConverter.ConvertO(labelColor);
                if (message != null)
                    callPayload.Queries["message"] = SourceExpressionConverter.ConvertO(message);
                if (color != null)
                    callPayload.Queries["color"] = SourceExpressionConverter.ConvertO(color);
                if (style != null)
                    callPayload.Queries["style"] = SourceExpressionConverter.ConvertO(style);
                if (logo != null)
                    callPayload.Queries["logo"] = SourceExpressionConverter.ConvertO(logo);
                if (logoColor != null)
                    callPayload.Queries["logoColor"] = SourceExpressionConverter.ConvertO(logoColor);
                if (logoWidth != null)
                    callPayload.Queries["logoWidth"] = SourceExpressionConverter.ConvertO(logoWidth);
                if (link != null)
                    callPayload.Queries["link"] = SourceExpressionConverter.ConvertO(link);
                callPayload.Queries["cacheSeconds"] = Convert.ToString(3600);
                if (cacheSeconds != null)
                    callPayload.Queries["cacheSeconds"] = SourceExpressionConverter.ConvertO(cacheSeconds);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        public IBodyWorkflowAction<JToken> BadgeGet([WorkflowExpression] Func<string> parameters)
        {
            SourceExpression.Validate(parameters, nameof(parameters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parameters, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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