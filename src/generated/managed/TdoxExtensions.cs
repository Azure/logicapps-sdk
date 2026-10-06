//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tdox
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TdoxActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tdox")]
        [WorkflowExpressionFactory(nameof(__BuildProductImport))]
        public IWorkflowAction ProductImport([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tdox")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductImport(WorkflowExpression<bodyInputItem[]> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Products/Import/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tdox")]
        [WorkflowExpressionFactory(nameof(__BuildCustomerImport))]
        public IWorkflowAction CustomerImport([WorkflowExpression] Func<bodyInputItem2[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tdox")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCustomerImport(WorkflowExpression<bodyInputItem2[]> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Customers/Import/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tdox")]
        [WorkflowExpressionFactory(nameof(__BuildListImport))]
        public IWorkflowAction ListImport([WorkflowExpression] Func<bodyInputItem22[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tdox")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildListImport(WorkflowExpression<bodyInputItem22[]> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/ListItems/Import/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class TdoxTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodyInputItem
    {
        public string UiProduct { get; set; }
        public string CdErpCode { get; set; }
        public string CdBarcode { get; set; }
        public string DsDescription { get; set; }
        public int FlPrice { get; set; }
        public int FlDiscount1 { get; set; }
        public int FlDiscount2 { get; set; }
        public int FlDiscount3 { get; set; }
        public int FlDiscount4 { get; set; }
        public int FlDiscount5 { get; set; }
        public int FlQty { get; set; }
        public string TxUm { get; set; }
        public int FlVat { get; set; }
        public string UiProductRevision { get; set; }
        public string AdditionalData { get; set; }
    }

    public class bodyInputItem2
    {
        public string Id { get; set; }
        public bool IsPerson { get; set; }
        public string BusinessName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ErpCode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string TaxCode { get; set; }
        public string VatCode { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string AdditionalData { get; set; }
    }

    public class bodyInputItem22
    {
        public string ListCode { get; set; }
        public string ListDescription { get; set; }
        public bodyInputItemItemsTypeItem[] Items { get; set; }
    }

    public class bodyInputItemItemsTypeItem
    {
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tdox;

    public partial class WorkflowManagedActions
    {
        public TdoxActions Tdox(string connectionId) => new TdoxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TdoxTriggers Tdox(string connectionId) => new TdoxTriggers(connectionId);
    }
}