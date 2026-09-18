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
        public IWorkflowAction Shipments([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyfromname = null, [WorkflowExpression] Func<string> bodyfromaddress = null, [WorkflowExpression] Func<string> bodyfromcity = null, [WorkflowExpression] Func<string> bodyfromzipCode = null, [WorkflowExpression] Func<string> bodyfromcountryCode = null, [WorkflowExpression] Func<string> bodyfromidNumber = null, [WorkflowExpression] Func<string> bodyfromstateCode = null, [WorkflowExpression] Func<string> bodyfromphone = null, [WorkflowExpression] Func<string> bodyfromemail = null, [WorkflowExpression] Func<string> bodyfromdistributionCenterId = null, [WorkflowExpression] Func<string> bodytoname = null, [WorkflowExpression] Func<string> bodytoaddress = null, [WorkflowExpression] Func<string> bodytocity = null, [WorkflowExpression] Func<string> bodytozipCode = null, [WorkflowExpression] Func<string> bodytocountryCode = null, [WorkflowExpression] Func<string> bodytoidNumber = null, [WorkflowExpression] Func<string> bodytostateCode = null, [WorkflowExpression] Func<string> bodytoobservations = null, [WorkflowExpression] Func<string> bodytophone = null, [WorkflowExpression] Func<string> bodytoemail = null, [WorkflowExpression] Func<string> bodytodistributionCenterId = null, [WorkflowExpression] Func<string> bodycostCenterCode = null, [WorkflowExpression] Func<string> bodyclientAdditionalInfocategory = null, [WorkflowExpression] Func<string> bodyserviceAttributescashOnDelivery = null, [WorkflowExpression] Func<string> bodyserviceCode = null, [WorkflowExpression] Func<string> bodydistributionCenterId = null, [WorkflowExpression] Func<string> bodycarrierCode = null, [WorkflowExpression] Func<string> bodyclientReference = null, [WorkflowExpression] Func<string> bodyshippingDate = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytotalAmount = null, [WorkflowExpression] Func<string> bodycustomsinvoiceId = null, [WorkflowExpression] Func<string> bodybatchreference = null, [WorkflowExpression] Func<string> bodyestimatedDate = null, [WorkflowExpression] Func<bodyparcelsInputItem[]> bodyparcels = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction Label([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> delivereaReference, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            var apiCallPath = String.Format("/shipments/{0}/label", ExpressionConverter.ConvertWithUrlEncoding(delivereaReference, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IBodyWorkflowAction<DistributionCentersResponse> DistributionCenters([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            var apiCallPath = "/distribution-centers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<DistributionCentersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IBodyWorkflowAction<CarriersInDistributionCenterResponse> CarriersInDistributionCenter([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> distributionCenter, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            var apiCallPath = String.Format("/distribution-centers/{0}/carriers", ExpressionConverter.ConvertWithUrlEncoding(distributionCenter, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<CarriersInDistributionCenterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction CancelShipment([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> delivereaReference, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            var apiCallPath = String.Format("/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(delivereaReference, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
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