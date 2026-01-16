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
        public IBodyWorkflowAction<string> SendSMS(Expression<Func<string>> apiKey, Expression<Func<string>> numbers, Expression<Func<string>> sender, Expression<Func<string>> msg, Expression<Func<string>> applicationType, Expression<Func<string>> lang, Expression<Func<string>> contentType)
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