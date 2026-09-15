//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deliverea
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DelivereaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction Shipments(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string>> bodyfromname = null, Expression<Func<string>> bodyfromaddress = null, Expression<Func<string>> bodyfromcity = null, Expression<Func<string>> bodyfromzipCode = null, Expression<Func<string>> bodyfromcountryCode = null, Expression<Func<string>> bodyfromidNumber = null, Expression<Func<string>> bodyfromstateCode = null, Expression<Func<string>> bodyfromphone = null, Expression<Func<string>> bodyfromemail = null, Expression<Func<string>> bodyfromdistributionCenterId = null, Expression<Func<string>> bodytoname = null, Expression<Func<string>> bodytoaddress = null, Expression<Func<string>> bodytocity = null, Expression<Func<string>> bodytozipCode = null, Expression<Func<string>> bodytocountryCode = null, Expression<Func<string>> bodytoidNumber = null, Expression<Func<string>> bodytostateCode = null, Expression<Func<string>> bodytoobservations = null, Expression<Func<string>> bodytophone = null, Expression<Func<string>> bodytoemail = null, Expression<Func<string>> bodytodistributionCenterId = null, Expression<Func<string>> bodycostCenterCode = null, Expression<Func<string>> bodyclientAdditionalInfocategory = null, Expression<Func<string>> bodyserviceAttributescashOnDelivery = null, Expression<Func<string>> bodyserviceCode = null, Expression<Func<string>> bodydistributionCenterId = null, Expression<Func<string>> bodycarrierCode = null, Expression<Func<string>> bodyclientReference = null, Expression<Func<string>> bodyshippingDate = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodytotalAmount = null, Expression<Func<string>> bodycustomsinvoiceId = null, Expression<Func<string>> bodybatchreference = null, Expression<Func<string>> bodyestimatedDate = null, Expression<Func<bodyparcelsInputItem[]>> bodyparcels = null)
        {
            var apiCallPath = "/shipments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            var fromObject = new JObject();
            var fromObjectpropCount = 0;
            if (bodyfromname != null)
            {
                fromObject["name"] = CSharpExpressionConverter.ConvertToken(bodyfromname);
                fromObjectpropCount++;
            }

            if (bodyfromaddress != null)
            {
                fromObject["address"] = CSharpExpressionConverter.ConvertToken(bodyfromaddress);
                fromObjectpropCount++;
            }

            if (bodyfromcity != null)
            {
                fromObject["city"] = CSharpExpressionConverter.ConvertToken(bodyfromcity);
                fromObjectpropCount++;
            }

            if (bodyfromzipCode != null)
            {
                fromObject["zipCode"] = CSharpExpressionConverter.ConvertToken(bodyfromzipCode);
                fromObjectpropCount++;
            }

            if (bodyfromcountryCode != null)
            {
                fromObject["countryCode"] = CSharpExpressionConverter.ConvertToken(bodyfromcountryCode);
                fromObjectpropCount++;
            }

            if (bodyfromidNumber != null)
            {
                fromObject["idNumber"] = CSharpExpressionConverter.ConvertToken(bodyfromidNumber);
                fromObjectpropCount++;
            }

            if (bodyfromstateCode != null)
            {
                fromObject["stateCode"] = CSharpExpressionConverter.ConvertToken(bodyfromstateCode);
                fromObjectpropCount++;
            }

            if (bodyfromphone != null)
            {
                fromObject["phone"] = CSharpExpressionConverter.ConvertToken(bodyfromphone);
                fromObjectpropCount++;
            }

            if (bodyfromemail != null)
            {
                fromObject["email"] = CSharpExpressionConverter.ConvertToken(bodyfromemail);
                fromObjectpropCount++;
            }

            if (bodyfromdistributionCenterId != null)
            {
                fromObject["distributionCenterId"] = CSharpExpressionConverter.ConvertToken(bodyfromdistributionCenterId);
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
                toObject["name"] = CSharpExpressionConverter.ConvertToken(bodytoname);
                toObjectpropCount++;
            }

            if (bodytoaddress != null)
            {
                toObject["address"] = CSharpExpressionConverter.ConvertToken(bodytoaddress);
                toObjectpropCount++;
            }

            if (bodytocity != null)
            {
                toObject["city"] = CSharpExpressionConverter.ConvertToken(bodytocity);
                toObjectpropCount++;
            }

            if (bodytozipCode != null)
            {
                toObject["zipCode"] = CSharpExpressionConverter.ConvertToken(bodytozipCode);
                toObjectpropCount++;
            }

            if (bodytocountryCode != null)
            {
                toObject["countryCode"] = CSharpExpressionConverter.ConvertToken(bodytocountryCode);
                toObjectpropCount++;
            }

            if (bodytoidNumber != null)
            {
                toObject["idNumber"] = CSharpExpressionConverter.ConvertToken(bodytoidNumber);
                toObjectpropCount++;
            }

            if (bodytostateCode != null)
            {
                toObject["stateCode"] = CSharpExpressionConverter.ConvertToken(bodytostateCode);
                toObjectpropCount++;
            }

            if (bodytoobservations != null)
            {
                toObject["observations"] = CSharpExpressionConverter.ConvertToken(bodytoobservations);
                toObjectpropCount++;
            }

            if (bodytophone != null)
            {
                toObject["phone"] = CSharpExpressionConverter.ConvertToken(bodytophone);
                toObjectpropCount++;
            }

            if (bodytoemail != null)
            {
                toObject["email"] = CSharpExpressionConverter.ConvertToken(bodytoemail);
                toObjectpropCount++;
            }

            if (bodytodistributionCenterId != null)
            {
                toObject["distributionCenterId"] = CSharpExpressionConverter.ConvertToken(bodytodistributionCenterId);
                toObjectpropCount++;
            }

            if (toObjectpropCount > 0)
            {
                body["to"] = toObject;
                bodypropCount++;
            }

            if (bodycostCenterCode != null)
            {
                body["costCenterCode"] = CSharpExpressionConverter.ConvertToken(bodycostCenterCode);
                bodypropCount++;
            }

            var clientAdditionalInfoObject = new JObject();
            var clientAdditionalInfoObjectpropCount = 0;
            if (bodyclientAdditionalInfocategory != null)
            {
                clientAdditionalInfoObject["category"] = CSharpExpressionConverter.ConvertToken(bodyclientAdditionalInfocategory);
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
                serviceAttributesObject["cashOnDelivery"] = CSharpExpressionConverter.ConvertToken(bodyserviceAttributescashOnDelivery);
                serviceAttributesObjectpropCount++;
            }

            if (serviceAttributesObjectpropCount > 0)
            {
                body["serviceAttributes"] = serviceAttributesObject;
                bodypropCount++;
            }

            if (bodyserviceCode != null)
            {
                body["serviceCode"] = CSharpExpressionConverter.ConvertToken(bodyserviceCode);
                bodypropCount++;
            }

            if (bodydistributionCenterId != null)
            {
                body["distributionCenterId"] = CSharpExpressionConverter.ConvertToken(bodydistributionCenterId);
                bodypropCount++;
            }

            if (bodycarrierCode != null)
            {
                body["carrierCode"] = CSharpExpressionConverter.ConvertToken(bodycarrierCode);
                bodypropCount++;
            }

            if (bodyclientReference != null)
            {
                body["clientReference"] = CSharpExpressionConverter.ConvertToken(bodyclientReference);
                bodypropCount++;
            }

            if (bodyshippingDate != null)
            {
                body["shippingDate"] = CSharpExpressionConverter.ConvertToken(bodyshippingDate);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodytotalAmount != null)
            {
                body["totalAmount"] = CSharpExpressionConverter.ConvertToken(bodytotalAmount);
                bodypropCount++;
            }

            var customsObject = new JObject();
            var customsObjectpropCount = 0;
            if (bodycustomsinvoiceId != null)
            {
                customsObject["invoiceId"] = CSharpExpressionConverter.ConvertToken(bodycustomsinvoiceId);
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
                batchObject["reference"] = CSharpExpressionConverter.ConvertToken(bodybatchreference);
                batchObjectpropCount++;
            }

            if (batchObjectpropCount > 0)
            {
                body["batch"] = batchObject;
                bodypropCount++;
            }

            if (bodyestimatedDate != null)
            {
                body["estimatedDate"] = CSharpExpressionConverter.ConvertToken(bodyestimatedDate);
                bodypropCount++;
            }

            if (bodyparcels != null)
            {
                body["parcels"] = CSharpExpressionConverter.ConvertToken(bodyparcels);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction Label(Expression<Func<string>> delivereaReference, Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/shipments/{0}/label", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(delivereaReference, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IBodyWorkflowAction<DistributionCentersResponse> DistributionCenters(Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var apiCallPath = "/distribution-centers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<DistributionCentersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IBodyWorkflowAction<CarriersInDistributionCenterResponse> CarriersInDistributionCenter(Expression<Func<string>> distributionCenter, Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/distribution-centers/{0}/carriers", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(distributionCenter, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<CarriersInDistributionCenterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction CancelShipment(Expression<Func<string>> delivereaReference, Expression<Func<string>> contentType, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/shipments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(delivereaReference, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction(callPayload);
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