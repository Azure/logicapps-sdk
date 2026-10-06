//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsnav2016
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Dynamicsnav2016Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllSalesOrder))]
        public IBodyWorkflowAction<ItemsList> GetAllSalesOrder([WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> instancename, [WorkflowExpression] Func<string> salesorderservice, [WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetAllSalesOrder(WorkflowExpression<string> company, WorkflowExpression<string> instancename, WorkflowExpression<string> salesorderservice, WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(instancename, nameof(instancename), required: true);
            WorkflowExpression.Validate(salesorderservice, nameof(salesorderservice), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/OData/Company('{1}')/{2}", ExpressionConverter.ConvertWithUrlEncoding(instancename, 1), ExpressionConverter.ConvertWithUrlEncoding(company, 1), ExpressionConverter.ConvertWithUrlEncoding(salesorderservice, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllSalesLine))]
        public IBodyWorkflowAction<ItemsList> GetAllSalesLine([WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> instancename, [WorkflowExpression] Func<string> salesorderservice, [WorkflowExpression] Func<string> ordernumber, [WorkflowExpression] Func<string> saleslineservice)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetAllSalesLine(WorkflowExpression<string> company, WorkflowExpression<string> instancename, WorkflowExpression<string> salesorderservice, WorkflowExpression<string> ordernumber, WorkflowExpression<string> saleslineservice)
        {
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(instancename, nameof(instancename), required: true);
            WorkflowExpression.Validate(salesorderservice, nameof(salesorderservice), required: true);
            WorkflowExpression.Validate(ordernumber, nameof(ordernumber), required: true);
            WorkflowExpression.Validate(saleslineservice, nameof(saleslineservice), required: true);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/OData/Company('{1}')/{2}(Document_Type='Order',No='{3}')/{4}", ExpressionConverter.ConvertWithUrlEncoding(instancename, 1), ExpressionConverter.ConvertWithUrlEncoding(company, 1), ExpressionConverter.ConvertWithUrlEncoding(salesorderservice, 1), ExpressionConverter.ConvertWithUrlEncoding(ordernumber, 1), ExpressionConverter.ConvertWithUrlEncoding(saleslineservice, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
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