//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Goqr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoqrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goqr")]
        public IBodyWorkflowAction<string> Create(Expression<Func<string>> data, Expression<Func<string>> size = null, Expression<Func<charsetSourceInput>> charsetSource = null, Expression<Func<charsetTargetInput>> charsetTarget = null, Expression<Func<string>> ecc = null, Expression<Func<string>> color = null, Expression<Func<string>> bgcolor = null, Expression<Func<int>> margin = null, Expression<Func<int>> qzone = null, Expression<Func<formatInput>> format = null)
        {
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_charsetSource = WorkflowExpression.Compile(charsetSource, nameof(charsetSource), required: false);
            var __workflow_charsetTarget = WorkflowExpression.Compile(charsetTarget, nameof(charsetTarget), required: false);
            var __workflow_ecc = WorkflowExpression.Compile(ecc, nameof(ecc), required: false);
            var __workflow_color = WorkflowExpression.Compile(color, nameof(color), required: false);
            var __workflow_bgcolor = WorkflowExpression.Compile(bgcolor, nameof(bgcolor), required: false);
            var __workflow_margin = WorkflowExpression.Compile(margin, nameof(margin), required: false);
            var __workflow_qzone = WorkflowExpression.Compile(qzone, nameof(qzone), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/create-qr-code/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["data"] = ExpressionConverter.Convert(__workflow_data);
                callPayload.Queries["size"] = Convert.ToString("200x200");
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Queries["charset-source"] = Convert.ToString("UTF-8");
                if (__workflow_charsetSource != null)
                    callPayload.Queries["charset-source"] = ExpressionConverter.Convert(__workflow_charsetSource);
                callPayload.Queries["charset-target"] = Convert.ToString("UTF-8");
                if (__workflow_charsetTarget != null)
                    callPayload.Queries["charset-target"] = ExpressionConverter.Convert(__workflow_charsetTarget);
                callPayload.Queries["ecc"] = Convert.ToString("L");
                if (__workflow_ecc != null)
                    callPayload.Queries["ecc"] = ExpressionConverter.Convert(__workflow_ecc);
                callPayload.Queries["color"] = Convert.ToString("0-0-0");
                if (__workflow_color != null)
                    callPayload.Queries["color"] = ExpressionConverter.Convert(__workflow_color);
                callPayload.Queries["bgcolor"] = Convert.ToString("255-255-255");
                if (__workflow_bgcolor != null)
                    callPayload.Queries["bgcolor"] = ExpressionConverter.Convert(__workflow_bgcolor);
                callPayload.Queries["margin"] = Convert.ToString(1);
                if (__workflow_margin != null)
                    callPayload.Queries["margin"] = ExpressionConverter.Convert(__workflow_margin);
                callPayload.Queries["qzone"] = Convert.ToString(0);
                if (__workflow_qzone != null)
                    callPayload.Queries["qzone"] = ExpressionConverter.Convert(__workflow_qzone);
                callPayload.Queries["format"] = Convert.ToString("png");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class GoqrTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum charsetSourceInput
    {
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591,
        [EnumMember(Value = "UTF-8")]
        UTF8
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum charsetTargetInput
    {
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591,
        [EnumMember(Value = "UTF-8")]
        UTF8
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "gif")]
        Gif,
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "jpg")]
        Jpg,
        [EnumMember(Value = "svg")]
        Svg,
        [EnumMember(Value = "eps")]
        Eps
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Goqr;

    public partial class WorkflowManagedActions
    {
        public GoqrActions Goqr(string connectionId) => new GoqrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GoqrTriggers Goqr(string connectionId) => new GoqrTriggers(connectionId);
    }
}
