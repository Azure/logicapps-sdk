//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsnav2016
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Dynamicsnav2016Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        public IBodyWorkflowAction<ItemsList> GetAllSalesOrder([WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> instancename, [WorkflowExpression] Func<string> salesorderservice, [WorkflowExpression] Func<string> filter = null)
        {
            SourceExpression.Validate(company, nameof(company), required: true);
            SourceExpression.Validate(instancename, nameof(instancename), required: true);
            SourceExpression.Validate(salesorderservice, nameof(salesorderservice), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/OData/Company('{1}')/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instancename, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(salesorderservice, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        public IBodyWorkflowAction<ItemsList> GetAllSalesLine([WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> instancename, [WorkflowExpression] Func<string> salesorderservice, [WorkflowExpression] Func<string> ordernumber, [WorkflowExpression] Func<string> saleslineservice)
        {
            SourceExpression.Validate(company, nameof(company), required: true);
            SourceExpression.Validate(instancename, nameof(instancename), required: true);
            SourceExpression.Validate(salesorderservice, nameof(salesorderservice), required: true);
            SourceExpression.Validate(ordernumber, nameof(ordernumber), required: true);
            SourceExpression.Validate(saleslineservice, nameof(saleslineservice), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/OData/Company('{1}')/{2}(Document_Type='Order',No='{3}')/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instancename, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(salesorderservice, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ordernumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(saleslineservice, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }
    }

    public class Dynamicsnav2016Triggers([ConnectionName] string connectionId)
    {
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsnav2016;

    public partial class WorkflowManagedActions
    {
        public Dynamicsnav2016Actions Dynamicsnav2016(string connectionId) => new Dynamicsnav2016Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Dynamicsnav2016Triggers Dynamicsnav2016(string connectionId) => new Dynamicsnav2016Triggers(connectionId);
    }
}