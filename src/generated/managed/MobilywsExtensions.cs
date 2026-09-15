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
            callPayload.Queries["apiKey"] = CSharpExpressionConverter.ConvertO(apiKey);
            callPayload.Queries["numbers"] = CSharpExpressionConverter.ConvertO(numbers);
            callPayload.Queries["sender"] = CSharpExpressionConverter.ConvertO(sender);
            callPayload.Queries["msg"] = CSharpExpressionConverter.ConvertO(msg);
            callPayload.Queries["applicationType"] = CSharpExpressionConverter.ConvertO(applicationType);
            callPayload.Queries["lang"] = CSharpExpressionConverter.ConvertO(lang);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
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