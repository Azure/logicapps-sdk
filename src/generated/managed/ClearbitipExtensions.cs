//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Clearbitip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClearbitipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clearbitip")]
        public IBodyWorkflowAction<JToken> LogoGet(Expression<Func<string>> domain, Expression<Func<int>> size = null, Expression<Func<formatInput>> format = null, Expression<Func<bool>> greyscale = null)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["size"] = Convert.ToString(128);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            callPayload.Queries["format"] = Convert.ToString("png");
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Queries["greyscale"] = Convert.ToString(false);
            if (greyscale != null)
                callPayload.Queries["greyscale"] = ExpressionConverter.Convert(greyscale);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ClearbitipTriggers([ConnectionName] string connectionId)
    {
    }

    public enum formatInput
    {
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "jpg")]
        Jpg
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Clearbitip;

    public partial class WorkflowManagedActions
    {
        public ClearbitipActions Clearbitip(string connectionId) => new ClearbitipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClearbitipTriggers Clearbitip(string connectionId) => new ClearbitipTriggers(connectionId);
    }
}