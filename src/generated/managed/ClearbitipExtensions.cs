//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clearbitip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClearbitipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clearbitip")]
        [WorkflowExpressionFactory(nameof(__BuildLogoGet))]
        public IBodyWorkflowAction<JToken> LogoGet([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> greyscale = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildLogoGet(WorkflowValue<string> domain, WorkflowValue<int> size = null, WorkflowValue<formatInput> format = null, WorkflowValue<bool> greyscale = null)
        {
            WorkflowValue.Validate(domain, nameof(domain), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(greyscale, nameof(greyscale), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1));
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
            });
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
