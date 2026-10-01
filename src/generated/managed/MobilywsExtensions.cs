//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobilyws
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobilywsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilyws")]
        public IBodyWorkflowAction<string> SendSMS([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> numbers, [WorkflowExpression] Func<string> sender, [WorkflowExpression] Func<string> msg, [WorkflowExpression] Func<string> applicationType, [WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<string> contentType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/msgSend.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["apiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["numbers"] = SourceExpressionConverter.ConvertO(numbers);
                callPayload.Queries["sender"] = SourceExpressionConverter.ConvertO(sender);
                callPayload.Queries["msg"] = SourceExpressionConverter.ConvertO(msg);
                callPayload.Queries["applicationType"] = SourceExpressionConverter.ConvertO(applicationType);
                callPayload.Queries["lang"] = SourceExpressionConverter.ConvertO(lang);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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