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
        public IBodyWorkflowAction<ItemsList> GetAllSalesOrder(Expression<Func<string>> company, Expression<Func<string>> instancename, Expression<Func<string>> salesorderservice, Expression<Func<string>> filter = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/OData/Company('{1}')/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(instancename, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(salesorderservice, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        public IBodyWorkflowAction<ItemsList> GetAllSalesLine(Expression<Func<string>> company, Expression<Func<string>> instancename, Expression<Func<string>> salesorderservice, Expression<Func<string>> ordernumber, Expression<Func<string>> saleslineservice)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/OData/Company('{1}')/{2}(Document_Type='Order',No='{3}')/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(instancename, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(salesorderservice, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ordernumber, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(saleslineservice, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ItemsList>(callPayload);
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