//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dbftoxmlconverter
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DbftoxmlconverterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dbftoxmlconverter")]
        public IWorkflowAction Dbf2XmlConvert(Expression<Func<string>> bodycontenType, Expression<Func<bodyencodingInput>> bodyencoding)
        {
            var apiCallPath = "/api/DBF2XML";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["code"] = Convert.ToString("ZeBVvhUSY/fpGA2uJTOKvIRTYkNXNQEl2TaHJO9Wq39wQB8ZXdYPWA==");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["conten_type"] = CSharpExpressionConverter.ConvertToken(bodycontenType);
            bodypropCount++;
            body["encoding"] = CSharpExpressionConverter.Convert(bodyencoding);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class DbftoxmlconverterTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodyencodingInput
    {
        [EnumMember(Value = "cp1251")]
        Cp1251,
        [EnumMember(Value = "cp866")]
        Cp866,
        [EnumMember(Value = "utf-8")]
        Utf8
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dbftoxmlconverter;

    public partial class WorkflowManagedActions
    {
        public DbftoxmlconverterActions Dbftoxmlconverter(string connectionId) => new DbftoxmlconverterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DbftoxmlconverterTriggers Dbftoxmlconverter(string connectionId) => new DbftoxmlconverterTriggers(connectionId);
    }
}