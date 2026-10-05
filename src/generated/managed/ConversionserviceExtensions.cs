//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Conversionservice
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConversionserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "conversionservice")]
        [WorkflowExpressionFactory(nameof(__BuildHtmlToText))]
        public IBodyWorkflowAction<string> HtmlToText([WorkflowExpression] Func<string> content = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildHtmlToText(WorkflowValue<string> content = null)
        {
            WorkflowValue.Validate(content, nameof(content), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/html2text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(content);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class ConversionserviceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Conversionservice;

    public partial class WorkflowManagedActions
    {
        public ConversionserviceActions Conversionservice(string connectionId) => new ConversionserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConversionserviceTriggers Conversionservice(string connectionId) => new ConversionserviceTriggers(connectionId);
    }
}
