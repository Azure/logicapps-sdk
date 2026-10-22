//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsnav2016
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Dynamicsnav2016Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetAllSalesOrder(Expression<Func<string>> company, Expression<Func<string>> instancename, Expression<Func<string>> salesorderservice, Expression<Func<string>> filter = null)
        {
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_instancename = WorkflowExpression.Compile(instancename, nameof(instancename), required: true);
            var __workflow_salesorderservice = WorkflowExpression.Compile(salesorderservice, nameof(salesorderservice), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/OData/Company('{1}')/{2}", __workflow_instancename.WithUrlEncoding(1), __workflow_company.WithUrlEncoding(1), __workflow_salesorderservice.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetAllSalesLine(Expression<Func<string>> company, Expression<Func<string>> instancename, Expression<Func<string>> salesorderservice, Expression<Func<string>> ordernumber, Expression<Func<string>> saleslineservice)
        {
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_instancename = WorkflowExpression.Compile(instancename, nameof(instancename), required: true);
            var __workflow_salesorderservice = WorkflowExpression.Compile(salesorderservice, nameof(salesorderservice), required: true);
            var __workflow_ordernumber = WorkflowExpression.Compile(ordernumber, nameof(ordernumber), required: true);
            var __workflow_saleslineservice = WorkflowExpression.Compile(saleslineservice, nameof(saleslineservice), required: true);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/OData/Company('{1}')/{2}(Document_Type='Order',No='{3}')/{4}", __workflow_instancename.WithUrlEncoding(1), __workflow_company.WithUrlEncoding(1), __workflow_salesorderservice.WithUrlEncoding(1), __workflow_ordernumber.WithUrlEncoding(1), __workflow_saleslineservice.WithUrlEncoding(1)));
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
