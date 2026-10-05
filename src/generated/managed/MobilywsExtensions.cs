//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobilyws
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobilywsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilyws")]
        [WorkflowExpressionFactory(nameof(__BuildSendSMS))]
        public IBodyWorkflowAction<string> SendSMS([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> numbers, [WorkflowExpression] Func<string> sender, [WorkflowExpression] Func<string> msg, [WorkflowExpression] Func<string> applicationType, [WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<string> contentType)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSendSMS(WorkflowValue<string> apiKey, WorkflowValue<string> numbers, WorkflowValue<string> sender, WorkflowValue<string> msg, WorkflowValue<string> applicationType, WorkflowValue<string> lang, WorkflowValue<string> contentType)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(numbers, nameof(numbers), required: true);
            WorkflowValue.Validate(sender, nameof(sender), required: true);
            WorkflowValue.Validate(msg, nameof(msg), required: true);
            WorkflowValue.Validate(applicationType, nameof(applicationType), required: true);
            WorkflowValue.Validate(lang, nameof(lang), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/msgSend.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["apiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["numbers"] = ExpressionConverter.Convert(numbers);
                callPayload.Queries["sender"] = ExpressionConverter.Convert(sender);
                callPayload.Queries["msg"] = ExpressionConverter.Convert(msg);
                callPayload.Queries["applicationType"] = ExpressionConverter.Convert(applicationType);
                callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class MobilywsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mobilyws;

    public partial class WorkflowManagedActions
    {
        public MobilywsActions Mobilyws(string connectionId) => new MobilywsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MobilywsTriggers Mobilyws(string connectionId) => new MobilywsTriggers(connectionId);
    }
}
