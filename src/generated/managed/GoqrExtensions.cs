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
        public IBodyWorkflowAction<string> Create([WorkflowExpression] Func<string> data, [WorkflowExpression] Func<string> size = null, [WorkflowExpression] Func<charsetSourceInput> charsetSource = null, [WorkflowExpression] Func<charsetTargetInput> charsetTarget = null, [WorkflowExpression] Func<string> ecc = null, [WorkflowExpression] Func<string> color = null, [WorkflowExpression] Func<string> bgcolor = null, [WorkflowExpression] Func<int> margin = null, [WorkflowExpression] Func<int> qzone = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create-qr-code/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["data"] = SourceExpressionConverter.ConvertO(data);
                callPayload.Queries["size"] = Convert.ToString("200x200");
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["charset-source"] = Convert.ToString("UTF-8");
                if (charsetSource != null)
                    callPayload.Queries["charset-source"] = SourceExpressionConverter.Convert(charsetSource);
                callPayload.Queries["charset-target"] = Convert.ToString("UTF-8");
                if (charsetTarget != null)
                    callPayload.Queries["charset-target"] = SourceExpressionConverter.Convert(charsetTarget);
                callPayload.Queries["ecc"] = Convert.ToString("L");
                if (ecc != null)
                    callPayload.Queries["ecc"] = SourceExpressionConverter.ConvertO(ecc);
                callPayload.Queries["color"] = Convert.ToString("0-0-0");
                if (color != null)
                    callPayload.Queries["color"] = SourceExpressionConverter.ConvertO(color);
                callPayload.Queries["bgcolor"] = Convert.ToString("255-255-255");
                if (bgcolor != null)
                    callPayload.Queries["bgcolor"] = SourceExpressionConverter.ConvertO(bgcolor);
                callPayload.Queries["margin"] = Convert.ToString(1);
                if (margin != null)
                    callPayload.Queries["margin"] = SourceExpressionConverter.ConvertO(margin);
                callPayload.Queries["qzone"] = Convert.ToString(0);
                if (qzone != null)
                    callPayload.Queries["qzone"] = SourceExpressionConverter.ConvertO(qzone);
                callPayload.Queries["format"] = Convert.ToString("png");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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