//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clearbitip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClearbitipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clearbitip")]
        public IBodyWorkflowAction<JToken> LogoGet([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> greyscale = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["size"] = Convert.ToString(128);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["format"] = Convert.ToString("png");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Queries["greyscale"] = Convert.ToString(false);
                if (greyscale != null)
                    callPayload.Queries["greyscale"] = SourceExpressionConverter.ConvertO(greyscale);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Clearbitip;

    public partial class WorkflowManagedActions
    {
        public ClearbitipActions Clearbitip(string connectionId) => new ClearbitipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClearbitipTriggers Clearbitip(string connectionId) => new ClearbitipTriggers(connectionId);
    }
}