//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deliverea
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DelivereaActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [WorkflowExpressionFactory(nameof(__BuildShipments))]
        public IWorkflowAction Shipments([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyfromname = null, [WorkflowExpression] Func<string> bodyfromaddress = null, [WorkflowExpression] Func<string> bodyfromcity = null, [WorkflowExpression] Func<string> bodyfromzipCode = null, [WorkflowExpression] Func<string> bodyfromcountryCode = null, [WorkflowExpression] Func<string> bodyfromidNumber = null, [WorkflowExpression] Func<string> bodyfromstateCode = null, [WorkflowExpression] Func<string> bodyfromphone = null, [WorkflowExpression] Func<string> bodyfromemail = null, [WorkflowExpression] Func<string> bodyfromdistributionCenterId = null, [WorkflowExpression] Func<string> bodytoname = null, [WorkflowExpression] Func<string> bodytoaddress = null, [WorkflowExpression] Func<string> bodytocity = null, [WorkflowExpression] Func<string> bodytozipCode = null, [WorkflowExpression] Func<string> bodytocountryCode = null, [WorkflowExpression] Func<string> bodytoidNumber = null, [WorkflowExpression] Func<string> bodytostateCode = null, [WorkflowExpression] Func<string> bodytoobservations = null, [WorkflowExpression] Func<string> bodytophone = null, [WorkflowExpression] Func<string> bodytoemail = null, [WorkflowExpression] Func<string> bodytodistributionCenterId = null, [WorkflowExpression] Func<string> bodycostCenterCode = null, [WorkflowExpression] Func<string> bodyclientAdditionalInfocategory = null, [WorkflowExpression] Func<string> bodyserviceAttributescashOnDelivery = null, [WorkflowExpression] Func<string> bodyserviceCode = null, [WorkflowExpression] Func<string> bodydistributionCenterId = null, [WorkflowExpression] Func<string> bodycarrierCode = null, [WorkflowExpression] Func<string> bodyclientReference = null, [WorkflowExpression] Func<string> bodyshippingDate = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytotalAmount = null, [WorkflowExpression] Func<string> bodycustomsinvoiceId = null, [WorkflowExpression] Func<string> bodybatchreference = null, [WorkflowExpression] Func<string> bodyestimatedDate = null, [WorkflowExpression] Func<bodyparcelsInputItem[]> bodyparcels = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildShipments(WorkflowExpression<string> contentType, WorkflowExpression<string> accept, WorkflowExpression<string> bodyfromname = null, WorkflowExpression<string> bodyfromaddress = null, WorkflowExpression<string> bodyfromcity = null, WorkflowExpression<string> bodyfromzipCode = null, WorkflowExpression<string> bodyfromcountryCode = null, WorkflowExpression<string> bodyfromidNumber = null, WorkflowExpression<string> bodyfromstateCode = null, WorkflowExpression<string> bodyfromphone = null, WorkflowExpression<string> bodyfromemail = null, WorkflowExpression<string> bodyfromdistributionCenterId = null, WorkflowExpression<string> bodytoname = null, WorkflowExpression<string> bodytoaddress = null, WorkflowExpression<string> bodytocity = null, WorkflowExpression<string> bodytozipCode = null, WorkflowExpression<string> bodytocountryCode = null, WorkflowExpression<string> bodytoidNumber = null, WorkflowExpression<string> bodytostateCode = null, WorkflowExpression<string> bodytoobservations = null, WorkflowExpression<string> bodytophone = null, WorkflowExpression<string> bodytoemail = null, WorkflowExpression<string> bodytodistributionCenterId = null, WorkflowExpression<string> bodycostCenterCode = null, WorkflowExpression<string> bodyclientAdditionalInfocategory = null, WorkflowExpression<string> bodyserviceAttributescashOnDelivery = null, WorkflowExpression<string> bodyserviceCode = null, WorkflowExpression<string> bodydistributionCenterId = null, WorkflowExpression<string> bodycarrierCode = null, WorkflowExpression<string> bodyclientReference = null, WorkflowExpression<string> bodyshippingDate = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodytotalAmount = null, WorkflowExpression<string> bodycustomsinvoiceId = null, WorkflowExpression<string> bodybatchreference = null, WorkflowExpression<string> bodyestimatedDate = null, WorkflowExpression<bodyparcelsInputItem[]> bodyparcels = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: true);
            WorkflowExpression.Validate(bodyfromname, nameof(bodyfromname), required: false);
            WorkflowExpression.Validate(bodyfromaddress, nameof(bodyfromaddress), required: false);
            WorkflowExpression.Validate(bodyfromcity, nameof(bodyfromcity), required: false);
            WorkflowExpression.Validate(bodyfromzipCode, nameof(bodyfromzipCode), required: false);
            WorkflowExpression.Validate(bodyfromcountryCode, nameof(bodyfromcountryCode), required: false);
            WorkflowExpression.Validate(bodyfromidNumber, nameof(bodyfromidNumber), required: false);
            WorkflowExpression.Validate(bodyfromstateCode, nameof(bodyfromstateCode), required: false);
            WorkflowExpression.Validate(bodyfromphone, nameof(bodyfromphone), required: false);
            WorkflowExpression.Validate(bodyfromemail, nameof(bodyfromemail), required: false);
            WorkflowExpression.Validate(bodyfromdistributionCenterId, nameof(bodyfromdistributionCenterId), required: false);
            WorkflowExpression.Validate(bodytoname, nameof(bodytoname), required: false);
            WorkflowExpression.Validate(bodytoaddress, nameof(bodytoaddress), required: false);
            WorkflowExpression.Validate(bodytocity, nameof(bodytocity), required: false);
            WorkflowExpression.Validate(bodytozipCode, nameof(bodytozipCode), required: false);
            WorkflowExpression.Validate(bodytocountryCode, nameof(bodytocountryCode), required: false);
            WorkflowExpression.Validate(bodytoidNumber, nameof(bodytoidNumber), required: false);
            WorkflowExpression.Validate(bodytostateCode, nameof(bodytostateCode), required: false);
            WorkflowExpression.Validate(bodytoobservations, nameof(bodytoobservations), required: false);
            WorkflowExpression.Validate(bodytophone, nameof(bodytophone), required: false);
            WorkflowExpression.Validate(bodytoemail, nameof(bodytoemail), required: false);
            WorkflowExpression.Validate(bodytodistributionCenterId, nameof(bodytodistributionCenterId), required: false);
            WorkflowExpression.Validate(bodycostCenterCode, nameof(bodycostCenterCode), required: false);
            WorkflowExpression.Validate(bodyclientAdditionalInfocategory, nameof(bodyclientAdditionalInfocategory), required: false);
            WorkflowExpression.Validate(bodyserviceAttributescashOnDelivery, nameof(bodyserviceAttributescashOnDelivery), required: false);
            WorkflowExpression.Validate(bodyserviceCode, nameof(bodyserviceCode), required: false);
            WorkflowExpression.Validate(bodydistributionCenterId, nameof(bodydistributionCenterId), required: false);
            WorkflowExpression.Validate(bodycarrierCode, nameof(bodycarrierCode), required: false);
            WorkflowExpression.Validate(bodyclientReference, nameof(bodyclientReference), required: false);
            WorkflowExpression.Validate(bodyshippingDate, nameof(bodyshippingDate), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodytotalAmount, nameof(bodytotalAmount), required: false);
            WorkflowExpression.Validate(bodycustomsinvoiceId, nameof(bodycustomsinvoiceId), required: false);
            WorkflowExpression.Validate(bodybatchreference, nameof(bodybatchreference), required: false);
            WorkflowExpression.Validate(bodyestimatedDate, nameof(bodyestimatedDate), required: false);
            WorkflowExpression.Validate(bodyparcels, nameof(bodyparcels), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/shipments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                var fromObject = new JObject();
                var fromObjectpropCount = 0;
                if (bodyfromname != null)
                {
                    fromObject["name"] = ExpressionConverter.ConvertO(bodyfromname);
                    fromObjectpropCount++;
                }

                if (bodyfromaddress != null)
                {
                    fromObject["address"] = ExpressionConverter.ConvertO(bodyfromaddress);
                    fromObjectpropCount++;
                }

                if (bodyfromcity != null)
                {
                    fromObject["city"] = ExpressionConverter.ConvertO(bodyfromcity);
                    fromObjectpropCount++;
                }

                if (bodyfromzipCode != null)
                {
                    fromObject["zipCode"] = ExpressionConverter.ConvertO(bodyfromzipCode);
                    fromObjectpropCount++;
                }

                if (bodyfromcountryCode != null)
                {
                    fromObject["countryCode"] = ExpressionConverter.ConvertO(bodyfromcountryCode);
                    fromObjectpropCount++;
                }

                if (bodyfromidNumber != null)
                {
                    fromObject["idNumber"] = ExpressionConverter.ConvertO(bodyfromidNumber);
                    fromObjectpropCount++;
                }

                if (bodyfromstateCode != null)
                {
                    fromObject["stateCode"] = ExpressionConverter.ConvertO(bodyfromstateCode);
                    fromObjectpropCount++;
                }

                if (bodyfromphone != null)
                {
                    fromObject["phone"] = ExpressionConverter.ConvertO(bodyfromphone);
                    fromObjectpropCount++;
                }

                if (bodyfromemail != null)
                {
                    fromObject["email"] = ExpressionConverter.ConvertO(bodyfromemail);
                    fromObjectpropCount++;
                }

                if (bodyfromdistributionCenterId != null)
                {
                    fromObject["distributionCenterId"] = ExpressionConverter.ConvertO(bodyfromdistributionCenterId);
                    fromObjectpropCount++;
                }

                if (fromObjectpropCount > 0)
                {
                    body["from"] = fromObject;
                    bodypropCount++;
                }

                var toObject = new JObject();
                var toObjectpropCount = 0;
                if (bodytoname != null)
                {
                    toObject["name"] = ExpressionConverter.ConvertO(bodytoname);
                    toObjectpropCount++;
                }

                if (bodytoaddress != null)
                {
                    toObject["address"] = ExpressionConverter.ConvertO(bodytoaddress);
                    toObjectpropCount++;
                }

                if (bodytocity != null)
                {
                    toObject["city"] = ExpressionConverter.ConvertO(bodytocity);
                    toObjectpropCount++;
                }

                if (bodytozipCode != null)
                {
                    toObject["zipCode"] = ExpressionConverter.ConvertO(bodytozipCode);
                    toObjectpropCount++;
                }

                if (bodytocountryCode != null)
                {
                    toObject["countryCode"] = ExpressionConverter.ConvertO(bodytocountryCode);
                    toObjectpropCount++;
                }

                if (bodytoidNumber != null)
                {
                    toObject["idNumber"] = ExpressionConverter.ConvertO(bodytoidNumber);
                    toObjectpropCount++;
                }

                if (bodytostateCode != null)
                {
                    toObject["stateCode"] = ExpressionConverter.ConvertO(bodytostateCode);
                    toObjectpropCount++;
                }

                if (bodytoobservations != null)
                {
                    toObject["observations"] = ExpressionConverter.ConvertO(bodytoobservations);
                    toObjectpropCount++;
                }

                if (bodytophone != null)
                {
                    toObject["phone"] = ExpressionConverter.ConvertO(bodytophone);
                    toObjectpropCount++;
                }

                if (bodytoemail != null)
                {
                    toObject["email"] = ExpressionConverter.ConvertO(bodytoemail);
                    toObjectpropCount++;
                }

                if (bodytodistributionCenterId != null)
                {
                    toObject["distributionCenterId"] = ExpressionConverter.ConvertO(bodytodistributionCenterId);
                    toObjectpropCount++;
                }

                if (toObjectpropCount > 0)
                {
                    body["to"] = toObject;
                    bodypropCount++;
                }

                if (bodycostCenterCode != null)
                {
                    body["costCenterCode"] = ExpressionConverter.ConvertO(bodycostCenterCode);
                    bodypropCount++;
                }

                var clientAdditionalInfoObject = new JObject();
                var clientAdditionalInfoObjectpropCount = 0;
                if (bodyclientAdditionalInfocategory != null)
                {
                    clientAdditionalInfoObject["category"] = ExpressionConverter.ConvertO(bodyclientAdditionalInfocategory);
                    clientAdditionalInfoObjectpropCount++;
                }

                if (clientAdditionalInfoObjectpropCount > 0)
                {
                    body["clientAdditionalInfo"] = clientAdditionalInfoObject;
                    bodypropCount++;
                }

                var serviceAttributesObject = new JObject();
                var serviceAttributesObjectpropCount = 0;
                if (bodyserviceAttributescashOnDelivery != null)
                {
                    serviceAttributesObject["cashOnDelivery"] = ExpressionConverter.ConvertO(bodyserviceAttributescashOnDelivery);
                    serviceAttributesObjectpropCount++;
                }

                if (serviceAttributesObjectpropCount > 0)
                {
                    body["serviceAttributes"] = serviceAttributesObject;
                    bodypropCount++;
                }

                if (bodyserviceCode != null)
                {
                    body["serviceCode"] = ExpressionConverter.ConvertO(bodyserviceCode);
                    bodypropCount++;
                }

                if (bodydistributionCenterId != null)
                {
                    body["distributionCenterId"] = ExpressionConverter.ConvertO(bodydistributionCenterId);
                    bodypropCount++;
                }

                if (bodycarrierCode != null)
                {
                    body["carrierCode"] = ExpressionConverter.ConvertO(bodycarrierCode);
                    bodypropCount++;
                }

                if (bodyclientReference != null)
                {
                    body["clientReference"] = ExpressionConverter.ConvertO(bodyclientReference);
                    bodypropCount++;
                }

                if (bodyshippingDate != null)
                {
                    body["shippingDate"] = ExpressionConverter.ConvertO(bodyshippingDate);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodytotalAmount != null)
                {
                    body["totalAmount"] = ExpressionConverter.ConvertO(bodytotalAmount);
                    bodypropCount++;
                }

                var customsObject = new JObject();
                var customsObjectpropCount = 0;
                if (bodycustomsinvoiceId != null)
                {
                    customsObject["invoiceId"] = ExpressionConverter.ConvertO(bodycustomsinvoiceId);
                    customsObjectpropCount++;
                }

                if (customsObjectpropCount > 0)
                {
                    body["customs"] = customsObject;
                    bodypropCount++;
                }

                var batchObject = new JObject();
                var batchObjectpropCount = 0;
                if (bodybatchreference != null)
                {
                    batchObject["reference"] = ExpressionConverter.ConvertO(bodybatchreference);
                    batchObjectpropCount++;
                }

                if (batchObjectpropCount > 0)
                {
                    body["batch"] = batchObject;
                    bodypropCount++;
                }

                if (bodyestimatedDate != null)
                {
                    body["estimatedDate"] = ExpressionConverter.ConvertO(bodyestimatedDate);
                    bodypropCount++;
                }

                if (bodyparcels != null)
                {
                    body["parcels"] = ExpressionConverter.ConvertO(bodyparcels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [WorkflowExpressionFactory(nameof(__BuildLabel))]
        public IWorkflowAction Label([WorkflowExpression] Func<string> delivereaReference, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLabel(WorkflowExpression<string> delivereaReference, WorkflowExpression<string> contentType, WorkflowExpression<string> accept)
        {
            WorkflowExpression.Validate(delivereaReference, nameof(delivereaReference), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/shipments/{0}/label", ExpressionConverter.ConvertWithUrlEncoding(delivereaReference, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [WorkflowExpressionFactory(nameof(__BuildDistributionCenters))]
        public IBodyWorkflowAction<DistributionCentersResponse> DistributionCenters([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DistributionCentersResponse> __BuildDistributionCenters(WorkflowExpression<string> contentType, WorkflowExpression<string> accept)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: true);
            return new DeferredBodyAction<DistributionCentersResponse>(() =>
            {
                var apiCallPath = "/distribution-centers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                return new ApiConnectionAction<DistributionCentersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [WorkflowExpressionFactory(nameof(__BuildCarriersInDistributionCenter))]
        public IBodyWorkflowAction<CarriersInDistributionCenterResponse> CarriersInDistributionCenter([WorkflowExpression] Func<string> distributionCenter, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CarriersInDistributionCenterResponse> __BuildCarriersInDistributionCenter(WorkflowExpression<string> distributionCenter, WorkflowExpression<string> contentType, WorkflowExpression<string> accept)
        {
            WorkflowExpression.Validate(distributionCenter, nameof(distributionCenter), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: true);
            return new DeferredBodyAction<CarriersInDistributionCenterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/distribution-centers/{0}/carriers", ExpressionConverter.ConvertWithUrlEncoding(distributionCenter, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                return new ApiConnectionAction<CarriersInDistributionCenterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [WorkflowExpressionFactory(nameof(__BuildCancelShipment))]
        public IWorkflowAction CancelShipment([WorkflowExpression] Func<string> delivereaReference, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelShipment(WorkflowExpression<string> delivereaReference, WorkflowExpression<string> contentType, WorkflowExpression<string> accept)
        {
            WorkflowExpression.Validate(delivereaReference, nameof(delivereaReference), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(delivereaReference, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class DelivereaTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodyparcelsInputItem
    {
        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }
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