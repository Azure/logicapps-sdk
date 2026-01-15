//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Conversionservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConversionserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "conversionservice")]
        public IBodyWorkflowAction<string> HtmlToText(Expression<Func<string>> content = null)
        {
            var apiCallPath = "/html2text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(content);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class ConversionserviceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Conversionservice;

    public partial class WorkflowManagedActions
    {
        public ConversionserviceActions Conversionservice(string connectionId) => new ConversionserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConversionserviceTriggers Conversionservice(string connectionId) => new ConversionserviceTriggers(connectionId);
    }
}