//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Goqr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoqrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goqr")]
        public IBodyWorkflowAction<string> Create(Expression<Func<string>> data, Expression<Func<string>> size = null, Expression<Func<charsetSourceInput>> charsetSource = null, Expression<Func<charsetTargetInput>> charsetTarget = null, Expression<Func<string>> ecc = null, Expression<Func<string>> color = null, Expression<Func<string>> bgcolor = null, Expression<Func<int>> margin = null, Expression<Func<int>> qzone = null, Expression<Func<formatInput>> format = null)
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