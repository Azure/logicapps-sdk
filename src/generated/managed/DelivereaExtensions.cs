//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deliverea
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DelivereaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Shipments(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<ShipmentsInput>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/shipments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Label(Expression<Func<string>> delivereaReference, Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var __workflow_delivereaReference = WorkflowExpression.Compile(delivereaReference, nameof(delivereaReference), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/shipments/{0}/label", __workflow_delivereaReference.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IBodyWorkflowAction<DistributionCentersResponse, ApiConnectionActionConfiguration> DistributionCenters(Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredBodyAction<DistributionCentersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/distribution-centers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<DistributionCentersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IBodyWorkflowAction<CarriersInDistributionCenterResponse, ApiConnectionActionConfiguration> CarriersInDistributionCenter(Expression<Func<string>> distributionCenter, Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var __workflow_distributionCenter = WorkflowExpression.Compile(distributionCenter, nameof(distributionCenter), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredBodyAction<CarriersInDistributionCenterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/distribution-centers/{0}/carriers", __workflow_distributionCenter.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<CarriersInDistributionCenterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CancelShipment(Expression<Func<string>> delivereaReference, Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var __workflow_delivereaReference = WorkflowExpression.Compile(delivereaReference, nameof(delivereaReference), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/shipments/{0}", __workflow_delivereaReference.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class DelivereaTriggers([ConnectionName] string connectionId)
    {
    }

    public class ShipmentsInput
    {
        [JsonProperty("from")]
        public ShipmentsInputFromType From { get; set; }

        [JsonProperty("to")]
        public ShipmentsInputToType To { get; set; }

        [JsonProperty("costCenterCode")]
        public string CostCenterCode { get; set; }

        [JsonProperty("clientAdditionalInfo")]
        public ShipmentsInputClientAdditionalInfoType ClientAdditionalInfo { get; set; }

        [JsonProperty("serviceAttributes")]
        public ShipmentsInputServiceAttributesType ServiceAttributes { get; set; }

        [JsonProperty("serviceCode")]
        public string ServiceCode { get; set; }

        [JsonProperty("distributionCenterId")]
        public string DistributionCenterId { get; set; }

        [JsonProperty("carrierCode")]
        public string CarrierCode { get; set; }

        [JsonProperty("clientReference")]
        public string ClientReference { get; set; }

        [JsonProperty("shippingDate")]
        public string ShippingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("totalAmount")]
        public string TotalAmount { get; set; }

        [JsonProperty("customs")]
        public ShipmentsInputCustomsType Customs { get; set; }

        [JsonProperty("batch")]
        public ShipmentsInputBatchType Batch { get; set; }

        [JsonProperty("estimatedDate")]
        public string EstimatedDate { get; set; }

        [JsonProperty("parcels")]
        public ShipmentsInputParcelsTypeItem[] Parcels { get; set; }
    }

    public class ShipmentsInputFromType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("idNumber")]
        public string IdNumber { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("distributionCenterId")]
        public string DistributionCenterId { get; set; }
    }

    public class ShipmentsInputToType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("idNumber")]
        public string IdNumber { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("observations")]
        public string Observations { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("distributionCenterId")]
        public string DistributionCenterId { get; set; }
    }

    public class ShipmentsInputClientAdditionalInfoType
    {
        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class ShipmentsInputServiceAttributesType
    {
        [JsonProperty("cashOnDelivery")]
        public string CashOnDelivery { get; set; }
    }

    public class ShipmentsInputCustomsType
    {
        [JsonProperty("invoiceId")]
        public string InvoiceId { get; set; }
    }

    public class ShipmentsInputBatchType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class ShipmentsInputParcelsTypeItem
    {
        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("height")]
        public double? Height { get; set; }

        [JsonProperty("width")]
        public double? Width { get; set; }

        [JsonProperty("length")]
        public double? Length { get; set; }
    }

    public class DistributionCentersResponse
    {
        [JsonProperty("data")]
        public DistributionCentersResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
    }

    public class DistributionCentersResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("worksAsDropPoint")]
        public bool WorksAsDropPoint { get; set; }
    }

    public class CarriersInDistributionCenterResponse
    {
        [JsonProperty("data")]
        public CarriersInDistributionCenterResponseDataTypeItem[] Data { get; set; }
    }

    public class CarriersInDistributionCenterResponseDataTypeItem
    {
        [JsonProperty("distributionCenterId")]
        public string DistributionCenterId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("costCenters")]
        public CarriersInDistributionCenterResponseDataTypeItemCostCentersTypeItem[] CostCenters { get; set; }
    }

    public class CarriersInDistributionCenterResponseDataTypeItemCostCentersTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("services")]
        public CarriersInDistributionCenterResponseDataTypeItemCostCentersTypeItemServicesTypeItem[] Services { get; set; }
    }

    public class CarriersInDistributionCenterResponseDataTypeItemCostCentersTypeItemServicesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Deliverea;

    public partial class WorkflowManagedActions
    {
        public DelivereaActions Deliverea(string connectionId) => new DelivereaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DelivereaTriggers Deliverea(string connectionId) => new DelivereaTriggers(connectionId);
    }
}