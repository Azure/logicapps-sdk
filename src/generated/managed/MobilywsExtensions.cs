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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSendSMS(WorkflowExpression<string> apiKey, WorkflowExpression<string> numbers, WorkflowExpression<string> sender, WorkflowExpression<string> msg, WorkflowExpression<string> applicationType, WorkflowExpression<string> lang, WorkflowExpression<string> contentType)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(numbers, nameof(numbers), required: true);
            WorkflowExpression.Validate(sender, nameof(sender), required: true);
            WorkflowExpression.Validate(msg, nameof(msg), required: true);
            WorkflowExpression.Validate(applicationType, nameof(applicationType), required: true);
            WorkflowExpression.Validate(lang, nameof(lang), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
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