//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Goqr
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoqrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goqr")]
        [WorkflowExpressionFactory(nameof(__BuildCreate))]
        public IBodyWorkflowAction<string> Create([WorkflowExpression] Func<string> data, [WorkflowExpression] Func<string> size = null, [WorkflowExpression] Func<charsetSourceInput> charsetSource = null, [WorkflowExpression] Func<charsetTargetInput> charsetTarget = null, [WorkflowExpression] Func<string> ecc = null, [WorkflowExpression] Func<string> color = null, [WorkflowExpression] Func<string> bgcolor = null, [WorkflowExpression] Func<int> margin = null, [WorkflowExpression] Func<int> qzone = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreate(WorkflowValue<string> data, WorkflowValue<string> size = null, WorkflowValue<charsetSourceInput> charsetSource = null, WorkflowValue<charsetTargetInput> charsetTarget = null, WorkflowValue<string> ecc = null, WorkflowValue<string> color = null, WorkflowValue<string> bgcolor = null, WorkflowValue<int> margin = null, WorkflowValue<int> qzone = null, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(data, nameof(data), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(charsetSource, nameof(charsetSource), required: false);
            WorkflowValue.Validate(charsetTarget, nameof(charsetTarget), required: false);
            WorkflowValue.Validate(ecc, nameof(ecc), required: false);
            WorkflowValue.Validate(color, nameof(color), required: false);
            WorkflowValue.Validate(bgcolor, nameof(bgcolor), required: false);
            WorkflowValue.Validate(margin, nameof(margin), required: false);
            WorkflowValue.Validate(qzone, nameof(qzone), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/create-qr-code/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["data"] = ExpressionConverter.Convert(data);
                callPayload.Queries["size"] = Convert.ToString("200x200");
                if (size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                callPayload.Queries["charset-source"] = Convert.ToString("UTF-8");
                if (charsetSource != null)
                    callPayload.Queries["charset-source"] = ExpressionConverter.Convert(charsetSource);
                callPayload.Queries["charset-target"] = Convert.ToString("UTF-8");
                if (charsetTarget != null)
                    callPayload.Queries["charset-target"] = ExpressionConverter.Convert(charsetTarget);
                callPayload.Queries["ecc"] = Convert.ToString("L");
                if (ecc != null)
                    callPayload.Queries["ecc"] = ExpressionConverter.Convert(ecc);
                callPayload.Queries["color"] = Convert.ToString("0-0-0");
                if (color != null)
                    callPayload.Queries["color"] = ExpressionConverter.Convert(color);
                callPayload.Queries["bgcolor"] = Convert.ToString("255-255-255");
                if (bgcolor != null)
                    callPayload.Queries["bgcolor"] = ExpressionConverter.Convert(bgcolor);
                callPayload.Queries["margin"] = Convert.ToString(1);
                if (margin != null)
                    callPayload.Queries["margin"] = ExpressionConverter.Convert(margin);
                callPayload.Queries["qzone"] = Convert.ToString(0);
                if (qzone != null)
                    callPayload.Queries["qzone"] = ExpressionConverter.Convert(qzone);
                callPayload.Queries["format"] = Convert.ToString("png");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class GoqrTriggers([ConnectionName] string connectionId)
    {
    }

    public enum charsetSourceInput
    {
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591,
        [EnumMember(Value = "UTF-8")]
        UTF8
    }

    public enum charsetTargetInput
    {
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591,
        [EnumMember(Value = "UTF-8")]
        UTF8
    }

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
