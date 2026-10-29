//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dbftoxmlconverter
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DbftoxmlconverterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dbftoxmlconverter")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Dbf2XmlConvert(Expression<Func<Dbf2XmlConvertInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/DBF2XML";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = Convert.ToString("ZeBVvhUSY/fpGA2uJTOKvIRTYkNXNQEl2TaHJO9Wq39wQB8ZXdYPWA==");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class DbftoxmlconverterTriggers([ConnectionName] string connectionId)
    {
    }

    public class Dbf2XmlConvertInput
    {
        [JsonProperty("conten_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContenType { get; set; }

        [JsonProperty("encoding", DefaultValueHandling = DefaultValueHandling.Include)]
        public Dbf2XmlConvertInputEncodingType Encoding { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Dbf2XmlConvertInputEncodingType
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