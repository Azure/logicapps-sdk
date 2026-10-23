//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shieldsioip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShieldsioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        public IBodyWorkflowAction<JToken> BadgeCreate(Expression<Func<string>> label = null, Expression<Func<string>> labelColor = null, Expression<Func<string>> message = null, Expression<Func<string>> color = null, Expression<Func<string>> style = null, Expression<Func<string>> logo = null, Expression<Func<string>> logoColor = null, Expression<Func<int>> logoWidth = null, Expression<Func<string>> link = null, Expression<Func<int>> cacheSeconds = null)
        {
            var __workflow_label = WorkflowExpression.Compile(label, nameof(label), required: false);
            var __workflow_labelColor = WorkflowExpression.Compile(labelColor, nameof(labelColor), required: false);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: false);
            var __workflow_color = WorkflowExpression.Compile(color, nameof(color), required: false);
            var __workflow_style = WorkflowExpression.Compile(style, nameof(style), required: false);
            var __workflow_logo = WorkflowExpression.Compile(logo, nameof(logo), required: false);
            var __workflow_logoColor = WorkflowExpression.Compile(logoColor, nameof(logoColor), required: false);
            var __workflow_logoWidth = WorkflowExpression.Compile(logoWidth, nameof(logoWidth), required: false);
            var __workflow_link = WorkflowExpression.Compile(link, nameof(link), required: false);
            var __workflow_cacheSeconds = WorkflowExpression.Compile(cacheSeconds, nameof(cacheSeconds), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/static/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_label != null)
                    callPayload.Queries["label"] = ExpressionConverter.Convert(__workflow_label);
                if (__workflow_labelColor != null)
                    callPayload.Queries["labelColor"] = ExpressionConverter.Convert(__workflow_labelColor);
                if (__workflow_message != null)
                    callPayload.Queries["message"] = ExpressionConverter.Convert(__workflow_message);
                if (__workflow_color != null)
                    callPayload.Queries["color"] = ExpressionConverter.Convert(__workflow_color);
                if (__workflow_style != null)
                    callPayload.Queries["style"] = ExpressionConverter.Convert(__workflow_style);
                if (__workflow_logo != null)
                    callPayload.Queries["logo"] = ExpressionConverter.Convert(__workflow_logo);
                if (__workflow_logoColor != null)
                    callPayload.Queries["logoColor"] = ExpressionConverter.Convert(__workflow_logoColor);
                if (__workflow_logoWidth != null)
                    callPayload.Queries["logoWidth"] = ExpressionConverter.Convert(__workflow_logoWidth);
                if (__workflow_link != null)
                    callPayload.Queries["link"] = ExpressionConverter.Convert(__workflow_link);
                callPayload.Queries["cacheSeconds"] = Convert.ToString(3600);
                if (__workflow_cacheSeconds != null)
                    callPayload.Queries["cacheSeconds"] = ExpressionConverter.Convert(__workflow_cacheSeconds);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        public IBodyWorkflowAction<JToken> BadgeGet(Expression<Func<string>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_parameters.WithUrlEncoding(1)));
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
