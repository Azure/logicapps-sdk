//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobilyws
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobilywsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilyws")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SendSMS(Expression<Func<string>> apiKey, Expression<Func<string>> numbers, Expression<Func<string>> sender, Expression<Func<string>> msg, Expression<Func<string>> applicationType, Expression<Func<string>> lang, Expression<Func<string>> contentType)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_numbers = WorkflowExpression.Compile(numbers, nameof(numbers), required: true);
            var __workflow_sender = WorkflowExpression.Compile(sender, nameof(sender), required: true);
            var __workflow_msg = WorkflowExpression.Compile(msg, nameof(msg), required: true);
            var __workflow_applicationType = WorkflowExpression.Compile(applicationType, nameof(applicationType), required: true);
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/msgSend.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["apiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["numbers"] = ExpressionConverter.Convert(__workflow_numbers);
                callPayload.Queries["sender"] = ExpressionConverter.Convert(__workflow_sender);
                callPayload.Queries["msg"] = ExpressionConverter.Convert(__workflow_msg);
                callPayload.Queries["applicationType"] = ExpressionConverter.Convert(__workflow_applicationType);
                callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
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
