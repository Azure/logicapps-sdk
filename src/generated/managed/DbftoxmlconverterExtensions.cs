//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dbftoxmlconverter
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DbftoxmlconverterActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dbftoxmlconverter")]
        [WorkflowExpressionFactory(nameof(__BuildDbf2XmlConvert))]
        public IWorkflowAction Dbf2XmlConvert([WorkflowExpression] Func<string> bodycontenType, [WorkflowExpression] Func<bodyencodingInput> bodyencoding)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dbftoxmlconverter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDbf2XmlConvert(WorkflowExpression<string> bodycontenType, WorkflowExpression<bodyencodingInput> bodyencoding)
        {
            WorkflowExpression.Validate(bodycontenType, nameof(bodycontenType), required: true);
            WorkflowExpression.Validate(bodyencoding, nameof(bodyencoding), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/DBF2XML";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = Convert.ToString("ZeBVvhUSY/fpGA2uJTOKvIRTYkNXNQEl2TaHJO9Wq39wQB8ZXdYPWA==");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["conten_type"] = ExpressionConverter.ConvertO(bodycontenType);
                bodypropCount++;
                body["encoding"] = ExpressionConverter.ConvertO(bodyencoding);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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