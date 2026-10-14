//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsnav2016
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Dynamicsnav2016Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        public IBodyWorkflowAction<ItemsList> GetAllSalesOrder(Expression<Func<string>> company, Expression<Func<string>> instancename, Expression<Func<string>> salesorderservice, Expression<Func<string>> filter = null)
        {
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            var __workflow_instancename = instancename == null ? null : WorkflowExpression.Compile(instancename);
            WorkflowExpression.Validate(__workflow_instancename, nameof(instancename), required: true);
            var __workflow_salesorderservice = salesorderservice == null ? null : WorkflowExpression.Compile(salesorderservice);
            WorkflowExpression.Validate(__workflow_salesorderservice, nameof(salesorderservice), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/OData/Company('{1}')/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_instancename, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_company, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_salesorderservice, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsnav2016")]
        public IBodyWorkflowAction<ItemsList> GetAllSalesLine(Expression<Func<string>> company, Expression<Func<string>> instancename, Expression<Func<string>> salesorderservice, Expression<Func<string>> ordernumber, Expression<Func<string>> saleslineservice)
        {
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            var __workflow_instancename = instancename == null ? null : WorkflowExpression.Compile(instancename);
            WorkflowExpression.Validate(__workflow_instancename, nameof(instancename), required: true);
            var __workflow_salesorderservice = salesorderservice == null ? null : WorkflowExpression.Compile(salesorderservice);
            WorkflowExpression.Validate(__workflow_salesorderservice, nameof(salesorderservice), required: true);
            var __workflow_ordernumber = ordernumber == null ? null : WorkflowExpression.Compile(ordernumber);
            WorkflowExpression.Validate(__workflow_ordernumber, nameof(ordernumber), required: true);
            var __workflow_saleslineservice = saleslineservice == null ? null : WorkflowExpression.Compile(saleslineservice);
            WorkflowExpression.Validate(__workflow_saleslineservice, nameof(saleslineservice), required: true);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/OData/Company('{1}')/{2}(Document_Type='Order',No='{3}')/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_instancename, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_company, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_salesorderservice, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_ordernumber, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_saleslineservice, 1));
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
