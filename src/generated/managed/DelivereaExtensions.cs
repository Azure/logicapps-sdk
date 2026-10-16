//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deliverea
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DelivereaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction Shipments(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string>> bodyfromname = null, Expression<Func<string>> bodyfromaddress = null, Expression<Func<string>> bodyfromcity = null, Expression<Func<string>> bodyfromzipCode = null, Expression<Func<string>> bodyfromcountryCode = null, Expression<Func<string>> bodyfromidNumber = null, Expression<Func<string>> bodyfromstateCode = null, Expression<Func<string>> bodyfromphone = null, Expression<Func<string>> bodyfromemail = null, Expression<Func<string>> bodyfromdistributionCenterId = null, Expression<Func<string>> bodytoname = null, Expression<Func<string>> bodytoaddress = null, Expression<Func<string>> bodytocity = null, Expression<Func<string>> bodytozipCode = null, Expression<Func<string>> bodytocountryCode = null, Expression<Func<string>> bodytoidNumber = null, Expression<Func<string>> bodytostateCode = null, Expression<Func<string>> bodytoobservations = null, Expression<Func<string>> bodytophone = null, Expression<Func<string>> bodytoemail = null, Expression<Func<string>> bodytodistributionCenterId = null, Expression<Func<string>> bodycostCenterCode = null, Expression<Func<string>> bodyclientAdditionalInfocategory = null, Expression<Func<string>> bodyserviceAttributescashOnDelivery = null, Expression<Func<string>> bodyserviceCode = null, Expression<Func<string>> bodydistributionCenterId = null, Expression<Func<string>> bodycarrierCode = null, Expression<Func<string>> bodyclientReference = null, Expression<Func<string>> bodyshippingDate = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodytotalAmount = null, Expression<Func<string>> bodycustomsinvoiceId = null, Expression<Func<string>> bodybatchreference = null, Expression<Func<string>> bodyestimatedDate = null, Expression<Func<bodyparcelsInputItem[]>> bodyparcels = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_bodyfromname = WorkflowExpression.Compile(bodyfromname, nameof(bodyfromname), required: false);
            var __workflow_bodyfromaddress = WorkflowExpression.Compile(bodyfromaddress, nameof(bodyfromaddress), required: false);
            var __workflow_bodyfromcity = WorkflowExpression.Compile(bodyfromcity, nameof(bodyfromcity), required: false);
            var __workflow_bodyfromzipCode = WorkflowExpression.Compile(bodyfromzipCode, nameof(bodyfromzipCode), required: false);
            var __workflow_bodyfromcountryCode = WorkflowExpression.Compile(bodyfromcountryCode, nameof(bodyfromcountryCode), required: false);
            var __workflow_bodyfromidNumber = WorkflowExpression.Compile(bodyfromidNumber, nameof(bodyfromidNumber), required: false);
            var __workflow_bodyfromstateCode = WorkflowExpression.Compile(bodyfromstateCode, nameof(bodyfromstateCode), required: false);
            var __workflow_bodyfromphone = WorkflowExpression.Compile(bodyfromphone, nameof(bodyfromphone), required: false);
            var __workflow_bodyfromemail = WorkflowExpression.Compile(bodyfromemail, nameof(bodyfromemail), required: false);
            var __workflow_bodyfromdistributionCenterId = WorkflowExpression.Compile(bodyfromdistributionCenterId, nameof(bodyfromdistributionCenterId), required: false);
            var __workflow_bodytoname = WorkflowExpression.Compile(bodytoname, nameof(bodytoname), required: false);
            var __workflow_bodytoaddress = WorkflowExpression.Compile(bodytoaddress, nameof(bodytoaddress), required: false);
            var __workflow_bodytocity = WorkflowExpression.Compile(bodytocity, nameof(bodytocity), required: false);
            var __workflow_bodytozipCode = WorkflowExpression.Compile(bodytozipCode, nameof(bodytozipCode), required: false);
            var __workflow_bodytocountryCode = WorkflowExpression.Compile(bodytocountryCode, nameof(bodytocountryCode), required: false);
            var __workflow_bodytoidNumber = WorkflowExpression.Compile(bodytoidNumber, nameof(bodytoidNumber), required: false);
            var __workflow_bodytostateCode = WorkflowExpression.Compile(bodytostateCode, nameof(bodytostateCode), required: false);
            var __workflow_bodytoobservations = WorkflowExpression.Compile(bodytoobservations, nameof(bodytoobservations), required: false);
            var __workflow_bodytophone = WorkflowExpression.Compile(bodytophone, nameof(bodytophone), required: false);
            var __workflow_bodytoemail = WorkflowExpression.Compile(bodytoemail, nameof(bodytoemail), required: false);
            var __workflow_bodytodistributionCenterId = WorkflowExpression.Compile(bodytodistributionCenterId, nameof(bodytodistributionCenterId), required: false);
            var __workflow_bodycostCenterCode = WorkflowExpression.Compile(bodycostCenterCode, nameof(bodycostCenterCode), required: false);
            var __workflow_bodyclientAdditionalInfocategory = WorkflowExpression.Compile(bodyclientAdditionalInfocategory, nameof(bodyclientAdditionalInfocategory), required: false);
            var __workflow_bodyserviceAttributescashOnDelivery = WorkflowExpression.Compile(bodyserviceAttributescashOnDelivery, nameof(bodyserviceAttributescashOnDelivery), required: false);
            var __workflow_bodyserviceCode = WorkflowExpression.Compile(bodyserviceCode, nameof(bodyserviceCode), required: false);
            var __workflow_bodydistributionCenterId = WorkflowExpression.Compile(bodydistributionCenterId, nameof(bodydistributionCenterId), required: false);
            var __workflow_bodycarrierCode = WorkflowExpression.Compile(bodycarrierCode, nameof(bodycarrierCode), required: false);
            var __workflow_bodyclientReference = WorkflowExpression.Compile(bodyclientReference, nameof(bodyclientReference), required: false);
            var __workflow_bodyshippingDate = WorkflowExpression.Compile(bodyshippingDate, nameof(bodyshippingDate), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodytotalAmount = WorkflowExpression.Compile(bodytotalAmount, nameof(bodytotalAmount), required: false);
            var __workflow_bodycustomsinvoiceId = WorkflowExpression.Compile(bodycustomsinvoiceId, nameof(bodycustomsinvoiceId), required: false);
            var __workflow_bodybatchreference = WorkflowExpression.Compile(bodybatchreference, nameof(bodybatchreference), required: false);
            var __workflow_bodyestimatedDate = WorkflowExpression.Compile(bodyestimatedDate, nameof(bodyestimatedDate), required: false);
            var __workflow_bodyparcels = WorkflowExpression.Compile(bodyparcels, nameof(bodyparcels), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/shipments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                var fromObject = new JObject();
                var fromObjectpropCount = 0;
                if (__workflow_bodyfromname != null)
                {
                    fromObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfromname);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromaddress != null)
                {
                    fromObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyfromaddress);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromcity != null)
                {
                    fromObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyfromcity);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromzipCode != null)
                {
                    fromObject["zipCode"] = ExpressionConverter.ConvertO(__workflow_bodyfromzipCode);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromcountryCode != null)
                {
                    fromObject["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodyfromcountryCode);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromidNumber != null)
                {
                    fromObject["idNumber"] = ExpressionConverter.ConvertO(__workflow_bodyfromidNumber);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromstateCode != null)
                {
                    fromObject["stateCode"] = ExpressionConverter.ConvertO(__workflow_bodyfromstateCode);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromphone != null)
                {
                    fromObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodyfromphone);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromemail != null)
                {
                    fromObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyfromemail);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromdistributionCenterId != null)
                {
                    fromObject["distributionCenterId"] = ExpressionConverter.ConvertO(__workflow_bodyfromdistributionCenterId);
                    fromObjectpropCount++;
                }

                if (fromObjectpropCount > 0)
                {
                    body["from"] = fromObject;
                    bodypropCount++;
                }

                var toObject = new JObject();
                var toObjectpropCount = 0;
                if (__workflow_bodytoname != null)
                {
                    toObject["name"] = ExpressionConverter.ConvertO(__workflow_bodytoname);
                    toObjectpropCount++;
                }

                if (__workflow_bodytoaddress != null)
                {
                    toObject["address"] = ExpressionConverter.ConvertO(__workflow_bodytoaddress);
                    toObjectpropCount++;
                }

                if (__workflow_bodytocity != null)
                {
                    toObject["city"] = ExpressionConverter.ConvertO(__workflow_bodytocity);
                    toObjectpropCount++;
                }

                if (__workflow_bodytozipCode != null)
                {
                    toObject["zipCode"] = ExpressionConverter.ConvertO(__workflow_bodytozipCode);
                    toObjectpropCount++;
                }

                if (__workflow_bodytocountryCode != null)
                {
                    toObject["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodytocountryCode);
                    toObjectpropCount++;
                }

                if (__workflow_bodytoidNumber != null)
                {
                    toObject["idNumber"] = ExpressionConverter.ConvertO(__workflow_bodytoidNumber);
                    toObjectpropCount++;
                }

                if (__workflow_bodytostateCode != null)
                {
                    toObject["stateCode"] = ExpressionConverter.ConvertO(__workflow_bodytostateCode);
                    toObjectpropCount++;
                }

                if (__workflow_bodytoobservations != null)
                {
                    toObject["observations"] = ExpressionConverter.ConvertO(__workflow_bodytoobservations);
                    toObjectpropCount++;
                }

                if (__workflow_bodytophone != null)
                {
                    toObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodytophone);
                    toObjectpropCount++;
                }

                if (__workflow_bodytoemail != null)
                {
                    toObject["email"] = ExpressionConverter.ConvertO(__workflow_bodytoemail);
                    toObjectpropCount++;
                }

                if (__workflow_bodytodistributionCenterId != null)
                {
                    toObject["distributionCenterId"] = ExpressionConverter.ConvertO(__workflow_bodytodistributionCenterId);
                    toObjectpropCount++;
                }

                if (toObjectpropCount > 0)
                {
                    body["to"] = toObject;
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterCode != null)
                {
                    body["costCenterCode"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterCode);
                    bodypropCount++;
                }

                var clientAdditionalInfoObject = new JObject();
                var clientAdditionalInfoObjectpropCount = 0;
                if (__workflow_bodyclientAdditionalInfocategory != null)
                {
                    clientAdditionalInfoObject["category"] = ExpressionConverter.ConvertO(__workflow_bodyclientAdditionalInfocategory);
                    clientAdditionalInfoObjectpropCount++;
                }

                if (clientAdditionalInfoObjectpropCount > 0)
                {
                    body["clientAdditionalInfo"] = clientAdditionalInfoObject;
                    bodypropCount++;
                }

                var serviceAttributesObject = new JObject();
                var serviceAttributesObjectpropCount = 0;
                if (__workflow_bodyserviceAttributescashOnDelivery != null)
                {
                    serviceAttributesObject["cashOnDelivery"] = ExpressionConverter.ConvertO(__workflow_bodyserviceAttributescashOnDelivery);
                    serviceAttributesObjectpropCount++;
                }

                if (serviceAttributesObjectpropCount > 0)
                {
                    body["serviceAttributes"] = serviceAttributesObject;
                    bodypropCount++;
                }

                if (__workflow_bodyserviceCode != null)
                {
                    body["serviceCode"] = ExpressionConverter.ConvertO(__workflow_bodyserviceCode);
                    bodypropCount++;
                }

                if (__workflow_bodydistributionCenterId != null)
                {
                    body["distributionCenterId"] = ExpressionConverter.ConvertO(__workflow_bodydistributionCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodycarrierCode != null)
                {
                    body["carrierCode"] = ExpressionConverter.ConvertO(__workflow_bodycarrierCode);
                    bodypropCount++;
                }

                if (__workflow_bodyclientReference != null)
                {
                    body["clientReference"] = ExpressionConverter.ConvertO(__workflow_bodyclientReference);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingDate != null)
                {
                    body["shippingDate"] = ExpressionConverter.ConvertO(__workflow_bodyshippingDate);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodytotalAmount != null)
                {
                    body["totalAmount"] = ExpressionConverter.ConvertO(__workflow_bodytotalAmount);
                    bodypropCount++;
                }

                var customsObject = new JObject();
                var customsObjectpropCount = 0;
                if (__workflow_bodycustomsinvoiceId != null)
                {
                    customsObject["invoiceId"] = ExpressionConverter.ConvertO(__workflow_bodycustomsinvoiceId);
                    customsObjectpropCount++;
                }

                if (customsObjectpropCount > 0)
                {
                    body["customs"] = customsObject;
                    bodypropCount++;
                }

                var batchObject = new JObject();
                var batchObjectpropCount = 0;
                if (__workflow_bodybatchreference != null)
                {
                    batchObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodybatchreference);
                    batchObjectpropCount++;
                }

                if (batchObjectpropCount > 0)
                {
                    body["batch"] = batchObject;
                    bodypropCount++;
                }

                if (__workflow_bodyestimatedDate != null)
                {
                    body["estimatedDate"] = ExpressionConverter.ConvertO(__workflow_bodyestimatedDate);
                    bodypropCount++;
                }

                if (__workflow_bodyparcels != null)
                {
                    body["parcels"] = ExpressionConverter.ConvertO(__workflow_bodyparcels);
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
        public IWorkflowAction Label(Expression<Func<string>> delivereaReference, Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var __workflow_delivereaReference = WorkflowExpression.Compile(delivereaReference, nameof(delivereaReference), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/shipments/{0}/label", ExpressionConverter.ConvertWithUrlEncoding(__workflow_delivereaReference, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IBodyWorkflowAction<DistributionCentersResponse> DistributionCenters(Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredBodyAction<DistributionCentersResponse>(() =>
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
        public IBodyWorkflowAction<CarriersInDistributionCenterResponse> CarriersInDistributionCenter(Expression<Func<string>> distributionCenter, Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var __workflow_distributionCenter = WorkflowExpression.Compile(distributionCenter, nameof(distributionCenter), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredBodyAction<CarriersInDistributionCenterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/distribution-centers/{0}/carriers", ExpressionConverter.ConvertWithUrlEncoding(__workflow_distributionCenter, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<CarriersInDistributionCenterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction CancelShipment(Expression<Func<string>> delivereaReference, Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var __workflow_delivereaReference = WorkflowExpression.Compile(delivereaReference, nameof(delivereaReference), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_delivereaReference, 1));
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
